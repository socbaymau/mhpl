using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PhieuThuController : Controller
    {
        private readonly VESOContext vsc;
        // GET: /<controller>/

        public PhieuThuController(VESOContext context)
        {
            vsc = context;
        }
        public IActionResult Index()
        {
            List<PhieuThu> list = vsc.PhieuThu.OrderBy(p => p.MaPt).Include(p => p.MaDlNavigation).ToList();
            List<DaiLy> daily = vsc.DaiLy.ToList();
            ViewBag.DaiLy = daily;
            return View(list);
        }
        //public IActionResult ThemPT()
        //public IActionResult ThemPT(String ngay, String daily, String tien)
        //{
        //    //PhieuThu pt = new PhieuThu();
        //    //pt.MaDl = Convert.ToInt32(daily);
        //    //pt.Ngay = Convert.ToDateTime(ngay);
        //    //pt.SoTien = 
        //    //vsc.PhieuThu.Add(pt);
        //    //vsc.SaveChanges();
        //    //return RedirectToAction("Index");

        //}
        //public IActionResult SuaThieuThu(String id, String ngay, String daily, String tien)
        //{
        //    var pt = vsc.PhieuThu.Where(x => x.MaPt == Convert.ToInt32(id)).SingleOrDefault();
        //    pt.Ngay = Convert.ToDateTime(ngay);
        //    pt.SoTien = Convert.ToDecimal(tien);
        //    pt.MaDl = Convert.ToInt32(daily);
        //    vsc.SaveChanges();
        //    return RedirectToAction("PhieuThu");
        //}
        //public IActionResult Sua(int maed, int eddaily, DateTime edngay, float edtien)
        //{
        //    PhieuThu pt = vsc.PhieuThu.Where(p => p.MaPt == maed).SingleOrDefault();
        //    pt.MaDl = eddaily;
        //    pt.Ngay = edngay;
        //    pt.SoTien = edtien;
        //    vsc.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        public IActionResult timkiem(String str)
        {
            List<PhieuThu> list = new List<PhieuThu>();
            list = vsc.PhieuThu.Where(pt => pt.MaPt.ToString().Contains(str) || pt.MaDlNavigation.Ten.Contains(str) || pt.Ngay.ToString().Contains(str) || pt.SoTien.ToString().Contains(str)).ToList();
            List<DaiLy> daily = vsc.DaiLy.ToList();
            ViewBag.DaiLy = daily;
            return View("Index",list);
        }
    }
}
