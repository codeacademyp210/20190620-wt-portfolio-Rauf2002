using Porto.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Porto.Areas.Admin.Controllers
{
    public class AboutNavController : Controller
    {
        // GET: Admin/AboutNav
        PortoContext db;

        public AboutNavController()
        {
            db = new PortoContext();
        }
        public ActionResult Index()
        {
            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                Models.ViewModelHome model = new Models.ViewModelHome();
                model.AboutNav = db.AboutNav.ToList();
                return View(model);
            }

            return RedirectToAction("Index", "Login");
        }


        public ActionResult Delete(int Id)
        {
            Models.AboutNav foundNav = db.AboutNav.FirstOrDefault(s => s.Id == Id);

            if (foundNav != null)
            {
                db.AboutNav.Remove(foundNav);
                db.SaveChanges();
            }
            else
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index", "Setting");
        }


        public ActionResult Create()
        {
            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                Models.ViewModelHome model = new Models.ViewModelHome();
                model.AboutNav = db.AboutNav.ToList();
                return View(model);
            }
            return RedirectToAction("Index", "Login");
        }

        public ActionResult CreateAction(Models.AboutNav newAboutNav)
        {
            db.AboutNav.Add(newAboutNav);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                Models.AboutNav aboutNav;

                aboutNav = db.AboutNav.FirstOrDefault(s => s.Id == Id);
                return View(aboutNav);
            }
            return RedirectToAction("Index", "Login");
        }


        public ActionResult EditAction(Models.AboutNav sentNav)
        {
            Models.AboutNav foundNav = db.AboutNav.FirstOrDefault(s => s.Id == sentNav.Id);
            foundNav.Icon = sentNav.Icon;
            foundNav.Name = sentNav.Name;


            db.SaveChanges();
            return RedirectToAction("Index", "Setting");
        }
    }
}