using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AboutMeProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Biography.";

            return View();
        }
        public ActionResult Hobbies()
        {
            ViewBag.Message = "My Hobbies";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get In touch";

            return View();
        }
        public ActionResult Justloop(string name, int id = 5)
        {
            
                ViewBag.Name = name;

                ViewBag.ID = id;

                return View();
        }
    }
}