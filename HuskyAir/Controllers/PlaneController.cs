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
    public class PlaneController : Controller
    {
        private DBModelsMaster db = new DBModelsMaster();

        // GET: Plane
        [AuthorizeCookie("Admin", "Pilot")]
        public ActionResult Index(string searchString)
        {
            return View(db.Planes.OrderBy(m => m.NNumber));
        }

        // GET: Plane/Details/5
        public ActionResult Details(int id)
        {
            Plane plane = db.Planes.Find(id);
            if (plane == null)
            {
                return HttpNotFound();
            }
            return View(plane);
        }

        // GET: Plane/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plane/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NNumber,fk_PilotIDNumber,Type,NumberOfEngines,NumberOfPassengers,CurrentLocation,WeightCapacity")] Plane plane)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Planes.Add(plane);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Pilot ID not found.");
                }
            }

            return View(plane);
        }

        // GET: Plane/Edit/5
        public ActionResult Edit(int id)
        {
            Plane plane = db.Planes.Find(id);
            if (plane == null)
            {
                return HttpNotFound();
            }
            return View(plane);
        }

        // POST: Plane/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NNumber,fk_PilotIDNumber,Type,NumberOfEngines,NumberOfPassengers,CurrentLocation,WeightCapacity")] Plane plane)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(plane).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }catch
                {
                    ModelState.AddModelError("", "Pilot ID not found.");
                }
                
            }
            return View(plane);
        }

        // GET: Plane/Delete/5
        public ActionResult Delete(int id)
        {
            Plane plane = db.Planes.Find(id);
            if (plane == null)
            {
                return HttpNotFound();
            }
            return View(plane);
        }

        // POST: Plane/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Plane plane = db.Planes.Find(id);
            db.Planes.Remove(plane);
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
