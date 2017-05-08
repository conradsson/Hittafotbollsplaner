using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hittafotbollsplaner.Models;

namespace Hittafotbollsplaner.Controllers
{
    public class FotbollsplanController : Controller
    {
        hittafotbollsplanerEntities db = new hittafotbollsplanerEntities();

        // GET: Fotbollsplan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Planid(string id)
        {
            fotbollsplaner aktuellFotbollsplan = db.fotbollsplaners.Find(Convert.ToInt32(id));

            return View("Index", aktuellFotbollsplan);
        }

        [HttpGet]
        public ActionResult _Rapportera()
        {
            return PartialView("_Rapportera");
        }

        public ActionResult FelOpen()
        {
                ViewBag.Fel = "y";
                return View("Index");

        }

        public ActionResult FelClose()
        {
            ViewBag.Fel = "";
            return View("Index");

        }
    }
}