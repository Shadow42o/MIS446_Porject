using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HuskyAir.Models;
using HuskyAir.Filters;

namespace HuskyAir.Controllers
{
    public class PilotController : Controller
    {
        private DBModelsMaster db = new DBModelsMaster();

        // GET: Pilot
        [AuthorizeCookie("Admin", "Pilot")]
        public ActionResult Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                return View(db.Pilot.Where(m => m.FirstName.Contains(searchString) || m.LastName.Contains(searchString)));
            }
            else
            {
                return View(db.Pilot.OrderBy(m => m.PilotIDNumber));
            }
        }

        // GET: Pilot/Details/5
        public ActionResult Details(int id)
        {
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
        public ActionResult Create([Bind(Include = "PilotIDNumber,FirstName,LastName,DOB,Address,City,State,ZipCode,PhoneNumber,EMailAddress,TotalHours,AverageRating")] Pilot pilot)
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
        public ActionResult Edit(int id)
        {
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
        public ActionResult Edit([Bind(Include = "PilotIDNumber,FirstName,LastName,DOB,Address,City,State,ZipCode,PhoneNumber,EMailAddress,TotalHours,AverageRating")] Pilot pilot)
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
        public ActionResult Delete(int id)
        {
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
        public ActionResult DeleteConfirmed(int id)
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
