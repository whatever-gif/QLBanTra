using QLBanTra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLBanTra.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult SanPham()
        {
            QLBH_TRAEntities db = new QLBH_TRAEntities();
            List<product> dssp = db.products.ToList();
            return View(dssp);
        }
        public ActionResult PriceASCSanPham()
        {
            QLBH_TRAEntities db = new QLBH_TRAEntities();
            List<product> dssp = db.products.OrderBy(p => p.price).ToList();

            return View(dssp);
        }
        public ActionResult PriceDESCSanPham()
        {
            QLBH_TRAEntities db = new QLBH_TRAEntities();
            List<product> dssp = db.products.OrderByDescending(p => p.price).ToList();

            return View(dssp);
        }
    }
}