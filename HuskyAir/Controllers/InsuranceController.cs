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
    public class InsuranceController : Controller
    {
        private DBModelsMaster db = new DBModelsMaster();

        // GET: Insurance
        [AuthorizeCookie("Admin")]
        public ActionResult Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                return View(db.Insurances.Where(m => m.CompanyName.Contains(searchString)));
            }
            else
            {
                return View(db.Insurances.OrderBy(m => m.InsuranceIDNumber));
            }
        }

        // GET: Insurance/Details/5
        public ActionResult Details(int id)
        {
            Insurance insurance = db.Insurances.Find(id);
            if (insurance == null)
            {
                return HttpNotFound();
            }
            return View(insurance);
        }

        // GET: Insurance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insurance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InsuranceIDNumber,CompanyName,Address,City,State,ZipCode,PhoneNumber,EMailAddress")] Insurance insurance)
        {
            if (ModelState.IsValid)
            {
                db.Insurances.Add(insurance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurance);
        }

        // GET: Insurance/Edit/5
        public ActionResult Edit(int id)
        {
            Insurance insurance = db.Insurances.Find(id);
            if (insurance == null)
            {
                return HttpNotFound();
            }
            return View(insurance);
        }

        // POST: Insurance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InsuranceIDNumber,CompanyName,Address,City,State,ZipCode,PhoneNumber,EMailAddress")] Insurance insurance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurance);
        }

        // GET: Insurance/Delete/5
        public ActionResult Delete(int id)
        {
            Insurance insurance = db.Insurances.Find(id);
            if (insurance == null)
            {
                return HttpNotFound();
            }
            return View(insurance);
        }

        // POST: Insurance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurance insurance = db.Insurances.Find(id);
            db.Insurances.Remove(insurance);
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
