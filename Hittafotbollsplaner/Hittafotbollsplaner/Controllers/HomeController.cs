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

        public ActionResult AutoComplete()
        {
            return View();
        }

        public ActionResult GetAutoCompleteData(string term)
        {
            hittafotbollsplanerEntities db = new hittafotbollsplanerEntities();

                        var result = db.fotbollsplaners.Where(x => x.Namn.Contains(term))
                .Select(s => new FotbollsplanerAutocomplete { Value = s.Namn, Namn = s.Namn + " " + s.Adress })
                .Union(db.fotbollsplaners.Where(x => x.Adress.Contains(term))
                .Select(s => new FotbollsplanerAutocomplete { Value = s.Adress, Namn = s.Namn + " " + s.Adress})).ToList();


            List<FotbollsplanerAutocomplete> sorteradLista = result.OrderBy(o => o.Namn).ToList(); // SORTERAR LISTAN I NAMNORDNING
            int index = 0;                                                           // KONTROLLERAR OM NAMNET ÄR DENSAMMA SOM
                                                                                    // NAMNET EFTERÅT. TAR I SÅ FALL BORT DUBLETTEN.
            while (index < sorteradLista.Count - 1)                                // NÄR HELA LISTAN ÄR KLAR SÅ BLIR LISTAN REN.
            {
                if (sorteradLista[index].Namn == sorteradLista[index + 1].Namn)
                {
                    sorteradLista.RemoveAt(index);
                }
                else
                {
                    index++;
                }
            }

            return Json(sorteradLista, JsonRequestBehavior.AllowGet);
        }
    }
}