using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PhieuChiController : Controller
    {
        private readonly VESOContext vsc;
        public PhieuChiController(VESOContext context)
        {
            vsc = context;
        }
        public IActionResult Index()
        {
            List<PhieuChi> list = vsc.PhieuChi.ToList();
            return View(list);
        }
        public IActionResult ThemPC(string ten,DateTime ngay,string tien,string noidung)
        {
            PhieuChi pc = new PhieuChi();
            pc.TenPhieuChi = ten;
            pc.Ngay = ngay;
            pc.SoTien=double.Parse(tien);
            pc.NoiDung = noidung;
            vsc.Add(pc);
            vsc.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Sua(int edma,string edten,DateTime edngay,string edtien,string ednoidung)
        {
            var pc = vsc.PhieuChi.Where(x => x.MaPc == edma).SingleOrDefault();
            pc.TenPhieuChi = edten;
            pc.Ngay = edngay;
            pc.SoTien = Double.Parse(edtien);
            pc.NoiDung = ednoidung;
            vsc.SaveChanges();
            return RedirectToAction("PhieuChi");
        }
    }
}