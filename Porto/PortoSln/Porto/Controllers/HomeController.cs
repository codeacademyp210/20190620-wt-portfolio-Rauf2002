using Porto.DAL;
using Porto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Porto.Controllers
{
    public class HomeController : Controller
    {
        private PortoContext db = new PortoContext();
        public ActionResult Index()
        {
            ViewModelHome model = new ViewModelHome();
            model.AboutNav = db.AboutNav.ToList();
            model.Admin = db.Admins.ToList();
            model.Blog = db.Blogs.ToList();
            model.ClientMessage = db.ClientMessages.ToList();
            model.Education = db.Education.ToList();
            model.Experience = db.Experiences.ToList();
            model.Language = db.Languages.ToList();
            model.PorButton = db.PorButtons.ToList();
            model.PorPhoto = db.PorPhotos.ToList();
            model.Recommendation = db.Recommendations.ToList();
            model.Setting = db.Settings.FirstOrDefault();
            model.Skill = db.Skills.ToList();

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}