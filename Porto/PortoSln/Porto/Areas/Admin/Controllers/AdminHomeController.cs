using Porto.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Porto.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: Admin/AdminHome
        PortoContext db;

        public AdminHomeController()
        {
            db = new PortoContext();
        }
        public ActionResult Index()
        {
            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                Models.Admin myAdmin = db.Admins.FirstOrDefault();
                return View(myAdmin);
            }
            return RedirectToAction("Index", "Login");
        }

    }
}