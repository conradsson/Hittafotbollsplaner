using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hittafotbollsplaner.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Nyplan()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Om()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}