using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoComplete.Models;

namespace AutoComplete.Controllers
{
    public class TestController : Controller
    {
        private ShopMyPhamEntities db = new ShopMyPhamEntities();
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult test(string term)
        {
            List<SanPham> list;
            list = db.SanPhams.Include("SanPhamHinhs").Where(x => x.TenSanPham.Contains(term)).ToList();
                    
            return Json(list.Select(x => new { TenSanPham = x.TenSanPham, TenHinh = x.SanPhamHinhs.FirstOrDefault().TenHinh}),JsonRequestBehavior.AllowGet);
        }

    }
}