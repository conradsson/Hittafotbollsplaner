using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hittafotbollsplaner.Models;

namespace Hittafotbollsplaner.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            hittafotbollsplanerEntities db = new hittafotbollsplanerEntities();
            FotbollsplanerModels model = new FotbollsplanerModels();
            List<fotbollsplaner> allaFotbollsplaner = db.fotbollsplaners.ToList();

            model.fotbollsplaner = allaFotbollsplaner;
            model.senasteFotbollsplaner = allaFotbollsplaner.OrderByDescending(o => o.Id);

            return View(model);
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