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
    public class CertificationController : Controller
    {
        private DBModelsMaster db = new DBModelsMaster();

        // GET: Certification
        [AuthorizeCookie("Admin", "Pilot")]
        public ActionResult Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                return View(db.Certifications.Where(m => m.Pilot.LastName.Contains(searchString) || m.Pilot.LastName.Contains(searchString)));
            }else
            {
                return View(db.Certifications.OrderBy(m => m.Pilot.PilotIDNumber));
            }
        }

        // GET: Certification/Details/5
        public ActionResult Details(int id)
        {
            Certification certification = db.Certifications.Find(id);
            if (certification == null)
            {
                return HttpNotFound();
            }
            return View(certification);
        }

        // GET: Certification/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Certification/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,fk_PilotIDNumber,Certification1")] Certification certification)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Certifications.Add(certification);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }catch
                {
                    //if something goes wrong
                }
            }

            return View(certification);
        }

        // GET: Certification/Edit/5
        public ActionResult Edit(int id)
        {
            Certification certification = db.Certifications.Find(id);
            if (certification == null)
            {
                return HttpNotFound();
            }
            return View(certification);
        }

        // POST: Certification/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,fk_PilotIDNumber,Certification1")] Certification certification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(certification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(certification);
        }

        // GET: Certification/Delete/5
        public ActionResult Delete(int id)
        {
            Certification certification = db.Certifications.Find(id);
            if (certification == null)
            {
                return HttpNotFound();
            }
            return View(certification);
        }

        // POST: Certification/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Certification certification = db.Certifications.Find(id);
            db.Certifications.Remove(certification);
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
