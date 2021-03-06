﻿using System;
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
    public class FinalsController : Controller
    {
        private CopaContext db = new CopaContext();

        // GET: Finals
        public ActionResult Index()
        {
            return View(db.Finals.ToList());
        }

        // GET: Finals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Final final = db.Finals.Find(id);
            if (final == null)
            {
                return HttpNotFound();
            }
            return View(final);
        }

        // GET: Finals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Finals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSelecao,NomeA")] Final final)
        {
            if (ModelState.IsValid)
            {
                db.Finals.Add(final);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(final);
        }

        // GET: Finals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Final final = db.Finals.Find(id);
            if (final == null)
            {
                return HttpNotFound();
            }
            return View(final);
        }

        // POST: Finals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSelecao,NomeA")] Final final)
        {
            if (ModelState.IsValid)
            {
                db.Entry(final).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(final);
        }

        // GET: Finals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Final final = db.Finals.Find(id);
            if (final == null)
            {
                return HttpNotFound();
            }
            return View(final);
        }

        // POST: Finals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Final final = db.Finals.Find(id);
            db.Finals.Remove(final);
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
