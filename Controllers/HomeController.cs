using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using finallab;

namespace finallab.Controllers
{
    public class HomeController : Controller
    {
        myDBEntities db = new myDBEntities();
        // GET: Home
        public ActionResult Index()
        {
           
            var p = db.tblproes.ToList();
            ViewBag.p = p;

            var imgs = db.tblimages.ToList();
            ViewBag.imgs = imgs;

            return View();
        }
        public ActionResult cat(int id)
        {
            var p = db.tblproes.Where(l => l.cid == id).ToList();
            ViewBag.p = p;
            var imgs = db.tblimages.ToList();
            ViewBag.imgs = imgs;
            return View();
        }

        public ActionResult pro(int id)
        {
            var p = db.tblproes.Where(l => l.pid == id).ToList();
            ViewBag.p = p;
            var imgs = db.tblimages.Where(l => l.pid ==id ).ToList();
            ViewBag.imgs = imgs;
            return View();
        
        }
    }
}
