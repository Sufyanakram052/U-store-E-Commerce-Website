using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using finallab;
namespace finallab.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(tbluser usr)
        {
            myDBEntities obj = new myDBEntities();
            var a = obj.tblusers.Where(l => l.uname.Equals(usr.uname) && l.upassword.Equals(usr.upassword)).ToList();
            if(a.Count> 0)
            {
                Session["uname"] = usr.uname.ToString();
                Session["upassword"] = usr.upassword.ToString();
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.msg = "Ivaild username and password!...";
            }
            return View();
        }

        public ActionResult Dashboard()
        {
            if(Session["uname"] == null)
            {
                ViewBag.msg = "Login First.......";
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}