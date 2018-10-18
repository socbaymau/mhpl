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
        public IActionResult Index()
        {
            return View();
        }
        public PhieuThuController(VESOContext context)
        {
            vsc = context;
        }
        public IActionResult PhieuThu()
        {
            List<PhieuThu> list = new List<PhieuThu>();
            list = vsc.PhieuThu.Include(pt => pt.MaDlNavigation).ToList();
            ViewData["dsDaily"] = vsc.DaiLy.ToList();
            List<DaiLy> daily = vsc.DaiLy.ToList();
            return View(list);
        }
        public IActionResult ThemPT(String ngay, String daily, String tien)
        {
            PhieuThu pt = new PhieuThu();
            pt.MaDl = Convert.ToInt32(daily);
            pt.SoTien = Convert.ToInt32(tien);
            pt.Ngay = Convert.ToDateTime(ngay);
            vsc.PhieuThu.Add(pt);
            vsc.SaveChanges();
            return RedirectToAction("PhieuThu");
        }
        public IActionResult SuaThieuThu(String id, String ngay, String daily, String tien)
        {
            var pt = vsc.PhieuThu.Where(x => x.MaPt == Convert.ToInt32(id)).SingleOrDefault();
            pt.Ngay = Convert.ToDateTime(ngay);
            pt.SoTien = Convert.ToDecimal(tien);
            pt.MaDl = Convert.ToInt32(daily);
            vsc.SaveChanges();
            return RedirectToAction("PhieuThu");
        }
        public IActionResult suaPT(String id)
        {
            ViewData["dsDL"] = vsc.DaiLy.ToList();
            PhieuThu pt = new PhieuThu();
            pt = vsc.PhieuThu.Where(x => x.MaPt == Convert.ToInt32(id)).SingleOrDefault();
            return View(pt);
        }
        public IActionResult timkiem(String str)
        {
            List<PhieuThu> list = new List<PhieuThu>();
            list = vsc.PhieuThu.Where(x => x.Ngay.Value.ToShortDateString().Contains(str)).Include(pt => pt.MaDlNavigation).ToList();
            ViewData["dsDaily"] = vsc.DaiLy.ToList();
            return View("PhieuThu",list);
        }
    }
}
