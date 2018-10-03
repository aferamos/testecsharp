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
    public class SemisController : Controller
    {
        private CopaContext db = new CopaContext();

        // GET: Semis
        public ActionResult Index()
        {
            return View(db.Semis.ToList());
        }

        // GET: Semis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Semi semi = db.Semis.Find(id);
            if (semi == null)
            {
                return HttpNotFound();
            }
            return View(semi);
        }

        // GET: Semis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Semis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSemi,NmA,NmB")] Semi semi)
        {
            if (ModelState.IsValid)
            {
                db.Semis.Add(semi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(semi);
        }

        // GET: Semis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Semi semi = db.Semis.Find(id);
            if (semi == null)
            {
                return HttpNotFound();
            }
            return View(semi);
        }

        // POST: Semis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSemi,NmA,NmB")] Semi semi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(semi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(semi);
        }

        // GET: Semis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Semi semi = db.Semis.Find(id);
            if (semi == null)
            {
                return HttpNotFound();
            }
            return View(semi);
        }

        // POST: Semis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Semi semi = db.Semis.Find(id);
            db.Semis.Remove(semi);
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
