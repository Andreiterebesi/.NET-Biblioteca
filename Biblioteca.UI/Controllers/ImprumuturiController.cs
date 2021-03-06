﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Biblioteca.UI.Models.BibliotecaModels;

namespace Biblioteca.UI.Controllers
{
    public class ImprumuturiController : Controller
    {
        private BibliotecaContext db = new BibliotecaContext();

        // GET: Imprumuts
        public ActionResult Index()
        {
            var imprumuturi = db.Imprumuturi.Include(i => i.Carte).Include(i => i.Client);
            return View(imprumuturi.ToList());
        }

        // GET: Imprumuts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imprumut imprumut = db.Imprumuturi.Find(id);
            if (imprumut == null)
            {
                return HttpNotFound();
            }
            return View(imprumut);
        }

        // GET: Imprumuts/Create
        public ActionResult Create()
        {
            ViewBag.CarteId = new SelectList(db.Carti, "CarteID", "Titlu");
            ViewBag.ClientId = new SelectList(db.Clienti, "ClientId", "Nume");
            return View();
        }

        // POST: Imprumuts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ImprumutId,ClientId,CarteId,DataImprumut")] Imprumut imprumut)
        {
            if (ModelState.IsValid)
            {
                db.Imprumuturi.Add(imprumut);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarteId = new SelectList(db.Carti, "CarteID", "Titlu", imprumut.CarteId);
            ViewBag.ClientId = new SelectList(db.Clienti, "ClientId", "Nume", imprumut.ClientId);
            return View(imprumut);
        }

        // GET: Imprumuts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imprumut imprumut = db.Imprumuturi.Find(id);
            if (imprumut == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarteId = new SelectList(db.Carti, "CarteID", "Titlu", imprumut.CarteId);
            ViewBag.ClientId = new SelectList(db.Clienti, "ClientId", "Nume", imprumut.ClientId);
            return View(imprumut);
        }

        // POST: Imprumuts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ImprumutId,ClientId,CarteId,DataImprumut")] Imprumut imprumut)
        {
            if (ModelState.IsValid)
            {
                db.Entry(imprumut).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarteId = new SelectList(db.Carti, "CarteID", "Titlu", imprumut.CarteId);
            ViewBag.ClientId = new SelectList(db.Clienti, "ClientId", "Nume", imprumut.ClientId);
            return View(imprumut);
        }

        // GET: Imprumuts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imprumut imprumut = db.Imprumuturi.Find(id);
            if (imprumut == null)
            {
                return HttpNotFound();
            }
            return View(imprumut);
        }

        // POST: Imprumuts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Imprumut imprumut = db.Imprumuturi.Find(id);
            db.Imprumuturi.Remove(imprumut);
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
