using Porto.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Porto.Areas.Admin.Controllers
{
    public class SettingController : Controller
    {
        // GET: Admin/Setting

        PortoContext db;

        public SettingController()
        {
            db = new PortoContext();
        }
        public ActionResult Index()
        {
            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                Models.ViewModelHome model = new Models.ViewModelHome();
                model.Setting = db.Settings.FirstOrDefault();
                return View(model);
            }

            return RedirectToAction("Index", "Login");
        }


        public ActionResult Delete(int Id)
        {
            Models.Setting foundSetting = db.Settings.FirstOrDefault(s => s.Id == Id);

            if (foundSetting != null)
            {
                db.Settings.Remove(foundSetting);
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
                model.Setting = db.Settings.FirstOrDefault();
                return View(model);
            }
            return RedirectToAction("Index", "Login");
        }

        public ActionResult CreateAction(Models.Setting newSetting)
        {
            db.Settings.Add(newSetting);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                Models.Setting setting;

                setting = db.Settings.FirstOrDefault(s => s.Id == Id);
                return View(setting);
            }
            return RedirectToAction("Index", "Login");
        }


        public ActionResult EditAction(Models.Setting sentSetting)
        {
            Models.Setting foundSetting = db.Settings.FirstOrDefault(s => s.Id == sentSetting.Id);
            foundSetting.Photo = sentSetting.Photo;
            foundSetting.FullName = sentSetting.FullName;
            foundSetting.Job = sentSetting.Job;
            foundSetting.PrevJob = sentSetting.PrevJob;
            foundSetting.Education = sentSetting.Education;
            foundSetting.AboutText = sentSetting.AboutText;
            foundSetting.Birthday = sentSetting.Birthday;
            foundSetting.Marital = sentSetting.Marital;
            foundSetting.Nationality = sentSetting.Nationality;
            foundSetting.Skype = sentSetting.Skype;
            foundSetting.Phone = sentSetting.Phone;
            foundSetting.Email = sentSetting.Email;


            db.SaveChanges();
            return RedirectToAction("Index","Setting");
        }
    }
}