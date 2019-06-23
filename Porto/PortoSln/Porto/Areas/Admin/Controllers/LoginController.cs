using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Porto.DAL;
using Porto.Models;

namespace Porto.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login

        private readonly PortoContext db;

        public LoginController()
        {
            db = new PortoContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn(Models.Admin admin)
        {
           // bool isMatch = true;

            Models.Admin foundAdmin = db.Admins.FirstOrDefault(a => a.Username == admin.Username);

            if (string.IsNullOrEmpty(admin.Username) || string.IsNullOrEmpty(admin.Password))
            {   
                Session["loginError"] = "Neither email nor password can be left empty";
                return RedirectToAction("Index", "Login");
            }

            if (foundAdmin != null)
            { 
                //isMatch = Crypto.VerifyHashedPassword(foundAdmin.Password, admin.Password);
                //return Content(Crypto.Hash(admin.Password, "md5"));
                if (foundAdmin.Password == Crypto.Hash(admin.Password, "md5"))
                {
                    Session["isLogin"] = true;
                    return RedirectToAction("Index", "AdminHome");
                }

            }
            Session["loginError"] = "Either email or password can not be found";

            return RedirectToAction("Index", "Login");
        }

        public ActionResult SignOut()
        {
            Session["isLogin"] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}