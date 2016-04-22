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
    public class PatientOutsidePartyController : Controller
    {
        private DBModelsMaster db = new DBModelsMaster();

        // GET: PatientOutsideParty
        [AuthorizeCookie("Admin")]
        public ActionResult Index()
        {
            var patientOutsideParties = db.PatientOutsideParties.Include(p => p.OutsideParty).Include(p => p.Patient);
            return View(patientOutsideParties.ToList());
        }

        // GET: PatientOutsideParty/Details/5
        public ActionResult Details(int id)
        {
            PatientOutsideParty patientOutsideParty = db.PatientOutsideParties.Find(id);
            if (patientOutsideParty == null)
            {
                return HttpNotFound();
            }
            return View(patientOutsideParty);
        }

        // GET: PatientOutsideParty/Create
        public ActionResult Create()
        {
            ViewBag.fk_OutsidePartyIDNumber = new SelectList(db.OutsideParties, "OutsidePartyIDNumber", "Title");
            ViewBag.fk_PatientIDNumber = new SelectList(db.Patients, "PatientIDNumber", "FirstName", "LastName");
            return View();
        }

        // POST: PatientOutsideParty/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,fk_PatientIDNumber,fk_OutsidePartyIDNumber")] PatientOutsideParty patientOutsideParty)
        {
            if (ModelState.IsValid)
            {
                db.PatientOutsideParties.Add(patientOutsideParty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fk_OutsidePartyIDNumber = new SelectList(db.OutsideParties, "OutsidePartyIDNumber", "Title", patientOutsideParty.fk_OutsidePartyIDNumber);
            ViewBag.fk_PatientIDNumber = new SelectList(db.Patients, "PatientIDNumber", "Name", patientOutsideParty.fk_PatientIDNumber);
            return View(patientOutsideParty);
        }

        // GET: PatientOutsideParty/Edit/5
        public ActionResult Edit(int id)
        {
            PatientOutsideParty patientOutsideParty = db.PatientOutsideParties.Find(id);
            if (patientOutsideParty == null)
            {
                return HttpNotFound();
            }
            ViewBag.fk_OutsidePartyIDNumber = new SelectList(db.OutsideParties, "OutsidePartyIDNumber", "Title", patientOutsideParty.fk_OutsidePartyIDNumber);
            ViewBag.fk_PatientIDNumber = new SelectList(db.Patients, "PatientIDNumber", "Name", patientOutsideParty.fk_PatientIDNumber);
            return View(patientOutsideParty);
        }

        // POST: PatientOutsideParty/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,fk_PatientIDNumber,fk_OutsidePartyIDNumber")] PatientOutsideParty patientOutsideParty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientOutsideParty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fk_OutsidePartyIDNumber = new SelectList(db.OutsideParties, "OutsidePartyIDNumber", "Title", patientOutsideParty.fk_OutsidePartyIDNumber);
            ViewBag.fk_PatientIDNumber = new SelectList(db.Patients, "PatientIDNumber", "Name", patientOutsideParty.fk_PatientIDNumber);
            return View(patientOutsideParty);
        }

        // GET: PatientOutsideParty/Delete/5
        public ActionResult Delete(int id)
        {
            PatientOutsideParty patientOutsideParty = db.PatientOutsideParties.Find(id);
            if (patientOutsideParty == null)
            {
                return HttpNotFound();
            }
            return View(patientOutsideParty);
        }

        // POST: PatientOutsideParty/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientOutsideParty patientOutsideParty = db.PatientOutsideParties.Find(id);
            db.PatientOutsideParties.Remove(patientOutsideParty);
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
