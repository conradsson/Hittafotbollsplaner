using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hittafotbollsplaner.Models;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Hittafotbollsplaner.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Kontakt(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("info.hittafotbollsplaner@gmail.com")); //replace with valid value
                message.Subject = "Från kontakt";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    ViewBag.SuccessEmail = "y";
                    return View();
                }
            }
            return View(model);
        }

        //public ActionResult Sent()
        //{
        //    ViewBag.SuccessEmail = "y";
        //    return View();
        //}

        public ActionResult Index()
        {
            hittafotbollsplanerEntities db = new hittafotbollsplanerEntities();
            FotbollsplanerModels model = new FotbollsplanerModels();
            List<fotbollsplaner> allaFotbollsplaner = db.fotbollsplaners.ToList();

            model.AllaFotbollsplaner = allaFotbollsplaner;
            model.fotbollsplaner = allaFotbollsplaner.Take(7);                                      // PLOCKAR UT 7 FRÅN LISTAN
            model.senasteFotbollsplaner = allaFotbollsplaner.OrderByDescending(o => o.Id).Take(7); // SORTERAR PÅ ID OCH  // PLOCKAR UT 7 FRÅN LISTAN

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