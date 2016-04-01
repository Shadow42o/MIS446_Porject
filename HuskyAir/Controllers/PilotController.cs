using System;
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
    public class PilotController : Controller
    {
        private PatientOutsidePartyModels db = new PatientOutsidePartyModels();

        // GET: Pilot
        public ActionResult Index()
        {
            return View(db.Pilots.ToList());
        }

        // GET: Pilot/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilot pilot = db.Pilots.Find(id);
            if (pilot == null)
            {
                return HttpNotFound();
            }
            return View(pilot);
        }

        // GET: Pilot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pilot/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PilotIDNumber,Name,DOB,Address,City,State,ZipCode,PhoneNumber,EMailAddress,TotalHours,AverageRating")] Pilot pilot)
        {
            if (ModelState.IsValid)
            {
                db.Pilots.Add(pilot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pilot);
        }

        // GET: Pilot/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilot pilot = db.Pilots.Find(id);
            if (pilot == null)
            {
                return HttpNotFound();
            }
            return View(pilot);
        }

        // POST: Pilot/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PilotIDNumber,Name,DOB,Address,City,State,ZipCode,PhoneNumber,EMailAddress,TotalHours,AverageRating")] Pilot pilot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pilot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pilot);
        }

        // GET: Pilot/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilot pilot = db.Pilots.Find(id);
            if (pilot == null)
            {
                return HttpNotFound();
            }
            return View(pilot);
        }

        // POST: Pilot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Pilot pilot = db.Pilots.Find(id);
            db.Pilots.Remove(pilot);
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
