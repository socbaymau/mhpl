using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using User.Models;

namespace User.Controllers
{
    public class ThongTinHoaDonController : Controller
    {
        // GET: ThongTinHoaDon
        private readonly QLSIMDTEntities entities=new QLSIMDTEntities();
        public ActionResult Index(string sdt)
        {
            List<HDCT> list = entities.HDCTs.Where(s => s.IDSIM == sdt).ToList();
            return View(list);
        }
    }
}