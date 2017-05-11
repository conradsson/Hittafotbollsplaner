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
    public class fotbollsplanersController : Controller
    {
        private hittafotbollsplanerEntities db = new hittafotbollsplanerEntities();

        // GET: fotbollsplaners
        public ActionResult Index()
        {
            return View(db.fotbollsplaners.ToList());
        }

        // GET: fotbollsplaners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fotbollsplaner fotbollsplaner = db.fotbollsplaners.Find(id);
            if (fotbollsplaner == null)
            {
                return HttpNotFound();
            }
            return View(fotbollsplaner);
        }

        public fotbollsplaner RightClickMapLink(string latlon)
        {
            fotbollsplaner model = new fotbollsplaner();

            latlon = latlon.Trim(' ').Trim('(').Trim(')');


            model.Latitud = latlon.Split(',')[0];
            model.Longitud = latlon.Split(',')[1].Trim(' ');


            return model;
        }




        // GET: fotbollsplaners/Create  
        public ActionResult Create()
        {
            return View();
        }



        // POST: fotbollsplaners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Namn,Adress,Ort,Postnummer,Latitud,Longitud,AntalGras,AntalGrus,AntalKonstGras,Parkering,Omkladnadsrum,Kafe,Restaurang,Upplyst,Bokning,Hemsida,Fritext")] fotbollsplaner fotbollsplaner)
        {
            if (ModelState.IsValid)
            {
                db.fotbollsplaners.Add(fotbollsplaner);
                db.SaveChanges();
                ViewBag.SuccessConfirm = "y";
                return View();
            }
            else
            {
            return View();
            }
        }

        // GET: fotbollsplaners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fotbollsplaner fotbollsplaner = db.fotbollsplaners.Find(id);
            if (fotbollsplaner == null)
            {
                return HttpNotFound();
            }
            return View(fotbollsplaner);
        }

        // POST: fotbollsplaners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Namn, Adress, Ort, Postnummer, Latitud, Longitud, AntalGras, AntalGrus, AntalKonstGras, Parkering, Omkladnadsrum, Kafe, Restaurang, Upplyst, Bokning, Hemsida, Fritext")] fotbollsplaner fotbollsplaner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fotbollsplaner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fotbollsplaner);
        }

        // GET: fotbollsplaners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fotbollsplaner fotbollsplaner = db.fotbollsplaners.Find(id);
            if (fotbollsplaner == null)
            {
                return HttpNotFound();
            }
            return View(fotbollsplaner);
        }

        // POST: fotbollsplaners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            fotbollsplaner fotbollsplaner = db.fotbollsplaners.Find(id);
            db.fotbollsplaners.Remove(fotbollsplaner);
            db.SaveChanges();
            return RedirectToAction("Index");
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
