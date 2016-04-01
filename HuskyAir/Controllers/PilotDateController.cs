﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HuskyAir.Models;

namespace HuskyAir.Controllers
{
    public class PilotDateController : Controller
    {
        private PatientOutsidePartyModels db = new PatientOutsidePartyModels();

        // GET: PilotDate
        public ActionResult Index()
        {
            return View(db.PilotDates.ToList());
        }

        // GET: PilotDate/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PilotDate pilotDate = db.PilotDates.Find(id);
            if (pilotDate == null)
            {
                return HttpNotFound();
            }
            return View(pilotDate);
        }

        // GET: PilotDate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PilotDate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,fk_PilotIDNumber,fk_PlaneIDNumber,StartDateAvailable,EndDateAvailable")] PilotDate pilotDate)
        {
            if (ModelState.IsValid)
            {
                db.PilotDates.Add(pilotDate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pilotDate);
        }

        // GET: PilotDate/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PilotDate pilotDate = db.PilotDates.Find(id);
            if (pilotDate == null)
            {
                return HttpNotFound();
            }
            return View(pilotDate);
        }

        // POST: PilotDate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,fk_PilotIDNumber,fk_PlaneIDNumber,StartDateAvailable,EndDateAvailable")] PilotDate pilotDate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pilotDate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pilotDate);
        }

        // GET: PilotDate/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PilotDate pilotDate = db.PilotDates.Find(id);
            if (pilotDate == null)
            {
                return HttpNotFound();
            }
            return View(pilotDate);
        }

        // POST: PilotDate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PilotDate pilotDate = db.PilotDates.Find(id);
            db.PilotDates.Remove(pilotDate);
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
