﻿using System;
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
    public class PatientController : Controller
    {
        private DBModelsMaster db = new DBModelsMaster();

        // GET: Patient
        [AuthorizeCookie("Admin")]
        public ActionResult Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                return View(db.Patients.Where(m => m.FirstName.Contains(searchString) || m.LastName.Contains(searchString)));
            }
            else
            {
                return View(db.Patients.OrderBy(m => m.PatientIDNumber));
            }
        }

        // GET: Patient/Details/5
        public ActionResult Details(int id)
        {
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // GET: Patient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patient/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PatientIDNumber,FirstName,LastName,DOB,Address,City,State,ZipCode,PhoneNumber,EMailAddress,SpecialNeeds,fk_InsuranceIDNumber")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Patients.Add(patient);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }catch
                {
                    ModelState.AddModelError("", "Insurance ID Not Found");
                }
                
            }

            return View(patient);
        }

        // GET: Patient/Edit/5
        public ActionResult Edit(int id)
        {
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patient/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PatientIDNumber,FirstName,LastName,DOB,Address,City,State,ZipCode,PhoneNumber,EMailAddress,SpecialNeeds,fk_InsuranceIDNumber")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(patient).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }catch
                {
                    ModelState.AddModelError("", "Insurance ID Not Found");
                }
            }
            return View(patient);
        }

        // GET: Patient/Delete/5
        public ActionResult Delete(int id)
        {
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patient patient = db.Patients.Find(id);
            db.Patients.Remove(patient);
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
