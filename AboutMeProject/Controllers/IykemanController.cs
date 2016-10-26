using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AboutMeProject.Controllers
{
    public class IykemanController : Controller
    {
        // GET: Iykeman
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Aloop(string name, int id = 10)
        {

            ViewBag.Name = name;

            ViewBag.ID = id;

            return View();
        }
    }
}