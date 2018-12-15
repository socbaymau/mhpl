using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace User.Models
{
    public class ThongTinSuDungController : Controller
    {
        // GET: ThongTinSuDung
        private readonly QLSIMDTEntities entities = new QLSIMDTEntities();
        // GET: ThongTinSuDung
        public ActionResult Index(string sdt)
        {
            List<CHITIETSD> list = entities.CHITIETSDs.Where(s => s.IDSIM == sdt).ToList();
            return View(list);
        }
    }
}