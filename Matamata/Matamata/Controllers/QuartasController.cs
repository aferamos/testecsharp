using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Matamata.Models;

namespace Matamata.Controllers
{
    public class QuartasController : Controller
    {
        private CopaContext db = new CopaContext();

        // GET: Quartas
        public ActionResult Index()
        {
            return View(db.Quartas.ToList());
        }

        // GET: Quartas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarta quarta = db.Quartas.Find(id);
            if (quarta == null)
            {
                return HttpNotFound();
            }
            return View(quarta);
        }

        // GET: Quartas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quartas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSelecao,NomeA,NomeB,NomeC,NomeD")] Quarta quarta)
        {
            if (ModelState.IsValid)
            {
                db.Quartas.Add(quarta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quarta);
        }

        // GET: Quartas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarta quarta = db.Quartas.Find(id);
            if (quarta == null)
            {
                return HttpNotFound();
            }
            return View(quarta);
        }

        // POST: Quartas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSelecao,NomeA,NomeB,NomeC,NomeD")] Quarta quarta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quarta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quarta);
        }

        // GET: Quartas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarta quarta = db.Quartas.Find(id);
            if (quarta == null)
            {
                return HttpNotFound();
            }
            return View(quarta);
        }

        // POST: Quartas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Quarta quarta = db.Quartas.Find(id);
            db.Quartas.Remove(quarta);
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
