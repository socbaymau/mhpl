using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class QuanLiController : Controller
    {
        private readonly VESOContext vsc;
        const int pageSize = 10;
        int pageNumber = 1;
        public int TongSoTrangLoaiVeSo()
        {
            List<LoaiVeSo> list = vsc.LoaiVeSo.ToList();
            return ((list.Count / pageSize) + 1);
        }
        public int TongSoTrangPhanPhoi()
        {
            List<PhanPhoi> list = vsc.PhanPhoi.ToList();
            return ((list.Count / pageSize) + 1);
        }
        public int TongSoTrangKQXS()
        {
            List<Kqxs> list = vsc.Kqxs.ToList();
            return ((list.Count / pageSize) + 1);
        }
        public IActionResult Index()
        {
            return View();
        }
        public QuanLiController(VESOContext context)
        {
            vsc = context;
        }
        public IActionResult LoaiVeso(int? pagenumber)
        {
            List<LoaiVeSo> veso = new List<LoaiVeSo>();
            pageNumber = pagenumber ?? 1;
            veso = vsc.LoaiVeSo.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            ViewBag.TongTrang = TongSoTrangLoaiVeSo();
            ViewBag.TrangHienTai = pageNumber;
            return View(veso);
        }
        public IActionResult ThemVS(string Tinh, string TinhTrang)
        {
            LoaiVeSo vs = new LoaiVeSo();
            vs.Tinh = Tinh;
            vs.TinhTrang = TinhTrang;
            vsc.LoaiVeSo.Add(vs);
            vsc.SaveChanges();
            return RedirectToAction("LoaiVeso");
        }
        public IActionResult SuaVS(int edMaVS, string edTinh, string edTinhTrang)
        {
            var veso = vsc.LoaiVeSo.Where(x => x.MaLvs == edMaVS).SingleOrDefault();
            veso.Tinh = edTinh;
            veso.TinhTrang = edTinhTrang;
            vsc.SaveChanges();
            return RedirectToAction("LoaiVeso");
        }
        public IActionResult TimKiemVS(string search)
        {
            List<LoaiVeSo> timkiem= vsc.LoaiVeSo.Where(x => Convert.ToString(x.MaLvs).Contains(search) || x.Tinh.Contains(search) || x.TinhTrang.Contains(search)).ToList();
            return View("LoaiVeSo", timkiem);
        }
        public IActionResult PhanPhoi(int? pagenumber)
        {
            pageNumber = pagenumber ?? 1;
            List<PhanPhoi> phanphoi = vsc.PhanPhoi.OrderBy(pp => pp.Ngay)
                                                  .ThenBy(pp => pp.MaDl)
                                                  .Include(pp => pp.MaDlNavigation)
                                                  .Include(pp=>pp.MaLvsNavigation)
                                                  .Skip(pageSize * (pageNumber - 1))
                                                  .Take(pageSize)
                                                  .ToList();
            ViewBag.TongTrang = TongSoTrangPhanPhoi();
            ViewBag.TrangHienTai = pageNumber;
            return View(phanphoi);
        }
        public IActionResult CapNhat ()
        {
           vsc.Database.ExecuteSqlCommand("Exec capnhatphanphoi");
            return RedirectToAction("PhanPhoi");
        }
        public IActionResult SuaPP(int mapp, int mavs, int madl, DateTime ngaypp, int slgiao, int slban)
        {
            var phanphoi = vsc.PhanPhoi.Where(x => x.MaPp == mapp).SingleOrDefault();
            //phanphoi.MaLvs = mavs;
            //phanphoi.MaDl = madl;
            //phanphoi.Ngay = ngaypp;
            phanphoi.SoLuongGiao = slgiao;
            string message = "";
            if (slban>slgiao)
            {
                message = "Số lượng bán không lớn hơn số lượng giao";
            }
            else
            {
                phanphoi.SoLuongBan = slban;
                vsc.SaveChanges();
            }
            return RedirectToAction("PhanPhoi","QuanLi", new { message = message });
        }

        public IActionResult TimKiemPP(string search)
        {
            List<PhanPhoi> timkiem =vsc.PhanPhoi.Where(x => Convert.ToString(x.MaPp).Contains(search) || Convert.ToString(x.MaDl).Contains(search) || Convert.ToString(x.MaLvs).Contains(search) || Convert.ToString(x.Ngay).Contains(search) || Convert.ToString(x.SoLuongGiao).Contains(search) || Convert.ToString(x.SoLuongBan).Contains(search)).ToList();
            return View("PhanPhoi", timkiem);
        }
        public IActionResult DaiLy()
        {
            List<DaiLy> daily = new List<DaiLy>();
            daily = vsc.DaiLy.ToList();
            return View(daily);
        }
        public IActionResult ThemDL(string Ten, string DiaChi, string DienThoai, string TinhTrang)
        {
            DaiLy dl = new DaiLy();
            dl.Ten = Ten;
            dl.DiaChi = DiaChi;
            dl.DienThoai = DienThoai;
            dl.TinhTrang = TinhTrang;
            vsc.DaiLy.Add(dl);
            vsc.SaveChanges();
            return RedirectToAction("DaiLy");
        }
        public IActionResult SuaDL (int edmadl,string edten,string eddiachi,string eddienthoai,string edtt)
        {
            var dl = vsc.DaiLy.Where(x => x.MaDl == edmadl).SingleOrDefault();
            dl.Ten = edten;
            dl.DiaChi = eddiachi;
            dl.DienThoai = eddienthoai;
            dl.TinhTrang = edtt;
            vsc.SaveChanges();
            return RedirectToAction("DaiLy");
        }
        public IActionResult TimKiemDL(string search)
        {
            List<DaiLy> timkiem = vsc.DaiLy.Where(x => Convert.ToString(x.MaDl).Contains(search) || x.Ten.Contains(search) || x.DiaChi.Contains(search) || x.DienThoai.Contains(search) || x.TinhTrang.Contains(search)).ToList();
            return View("DaiLy", timkiem);
        }
        public IActionResult ThongTinDK(int id)
        {
            List<SldangKy> dki = vsc.SldangKy.Where(x => x.MaDl == id)
                                .Include(x => x.MaDlNavigation)
                                   .Include(x => x.MaLvsNavigation)
                                .OrderByDescending(x => x.NgayDangKy)
                                .ToList();
            ViewBag.ThongTin = dki;

            return PartialView("p_ThongTinDK", dki);
        }
        //public IActionResult LayThongTinDL(int id)
        //{
          
        //    List<LoaiVeSo> list = vsc.LoaiVeSo.ToList();
        //    DaiLy daily = vsc.DaiLy.Where(dl => dl.MaDl == id).SingleOrDefault();
        //    ViewBag.ThongTinDL = daily;
        //    return PartialView("ThemSLDK", list);
        //}
        public IActionResult ModalSLDK(string ma)
        {
            DaiLy daily = vsc.DaiLy.Where(dl => dl.MaDl == int.Parse(ma)).SingleOrDefault();
            List<LoaiVeSo> list = vsc.LoaiVeSo.ToList();
            ViewBag.ThongTinDL = daily;
            return PartialView("ThemSLDK", list);
        }
        public IActionResult ThemSLDK(int pmadl, int pmalvs, DateTime pngaydki,int psoluong)
        {
            DaiLy daily = vsc.DaiLy.Where(dl => dl.MaDl == pmadl).SingleOrDefault();
            SldangKy sl = new SldangKy();
            sl.MaDl = daily.MaDl;
            sl.MaLvs =pmalvs;
            sl.NgayDangKy = pngaydki;
            sl.SoLuong = psoluong;
            vsc.SldangKy.Add(sl);
            vsc.SaveChanges();
            return RedirectToAction("DaiLy");
        }
        [HttpGet]
        public IActionResult KQXS()
        {

            List<object> list = new List<object>();
            list.Add(vsc.Kqxs.OrderByDescending(x => x.Ngay).ToList());
            list.Add(vsc.LoaiVeSo.ToList());
            list.Add(vsc.PhanPhoi.ToList());
            list.Add(vsc.Giai.ToList());
            return View(list);
        }
        [HttpPost]
        public IActionResult ThemKQXS(int mavs, int sotrung, int kq, int giai, DateTime ngay)
        {
            ngay = DateTime.Now;
            Kqxs xs = new Kqxs();
            xs.MaKq = kq;
            xs.MaLvs = mavs;
            xs.MaGiai = giai;
            xs.SoTrung = sotrung;
            xs.Ngay = ngay;
            vsc.Kqxs.Add(xs);
            vsc.SaveChanges();
            return RedirectToAction("KQXS", "QuanLi");

        }
        [HttpPost]
        public IActionResult SuaKQXS(int makq, int edMaVS, int edGiai)
        {
            var xs = vsc.Kqxs.Where(x => x.MaKq == makq).SingleOrDefault();
            xs.MaGiai = edGiai;
            xs.MaLvs = edMaVS;
            vsc.SaveChanges();
            return RedirectToAction("KQXS", "QuanLi");
        }
    }
}