using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CongNoController : Controller
    {
        private readonly VESOContext vsc;
        public CongNoController(VESOContext context)
        {
            vsc = context;
        }
        public IActionResult Index()
        {
            List<CongNo> list = vsc.CongNo.Include(s => s.MaDlNavigation).ToList();
            return View(list);
        }
        public IActionResult ThemCN()
        {
            var soluongban = vsc.PhanPhoi.Select(sl => sl.SoLuongBan).ToList();
            List<PhanPhoi> laydl = vsc.PhanPhoi.ToList();
            //List<CongNo> list=vsc.CongNo.To
            CongNo cn = new CongNo();
            foreach(var item in laydl)
            {
                if(item.SoLuongBan!=0 && item.SoLuongBan!=null)
                {
                    cn.MaDl = item.MaDl;
                    cn.Ngay = DateTime.Now;
                    cn.SoTien = 10000;
                    cn.HoaHong = item.MaDlNavigation.HoaHong;
                    cn.TongTien = (item.SoLuongBan * cn.SoTien * (1 - 1 / cn.HoaHong));
                    vsc.Add(cn);
                }
            }
            vsc.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Search(string str)
        {
            List<CongNo> list = vsc.CongNo.Where(c => c.MaCn.ToString().Contains(str) || c.MaDlNavigation.Ten.Contains(str) || c.Ngay.ToString().Contains(str) || c.SoTien.ToString().Contains(str) || c.TongTien.ToString().Contains(str)).ToList();
            return View("Index",list);
        }
        public IActionResult ThemPT(int add_Madl,DateTime add_Ngay, string add_Tien,string add_DaTra)
        {
            PhieuThu pt = new PhieuThu();
            pt.MaDl = add_Madl;
            pt.Ngay = add_Ngay;
            pt.SoTien = double.Parse(add_Tien);
            pt.Tra = double.Parse(add_DaTra);
            pt.ConLai = double.Parse(add_Tien) - double.Parse(add_DaTra);
            vsc.Add(pt);
            vsc.SaveChanges();
            return RedirectToAction("Index", "PhieuThu");
        }
    }
}