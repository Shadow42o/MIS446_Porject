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
    public class OutsidePartiesController : Controller
    {
        private DBModelsMaster db = new DBModelsMaster();

        // GET: OutsideParties
        [AuthorizeCookie("Admin")]
        public ActionResult Index()
        {
            return View(db.OutsideParties.ToList());
        }

        // GET: OutsideParties/Details/5
        public ActionResult Details(int id)
        {
            OutsideParty outsideParty = db.OutsideParties.Find(id);
            if (outsideParty == null)
            {
                return HttpNotFound();
            }
            return View(outsideParty);
        }

        // GET: OutsideParties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OutsideParties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OutsidePartyIDNumber,Title,Address,City,State,ZipCode,PhoneNumber,EmailAddress")] OutsideParty outsideParty)
        {
            if (ModelState.IsValid)
            {
                db.OutsideParties.Add(outsideParty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(outsideParty);
        }

        // GET: OutsideParties/Edit/5
        public ActionResult Edit(int id)
        {
            OutsideParty outsideParty = db.OutsideParties.Find(id);
            if (outsideParty == null)
            {
                return HttpNotFound();
            }
            return View(outsideParty);
        }

        // POST: OutsideParties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OutsidePartyIDNumber,Title,Address,City,State,ZipCode,PhoneNumber,EmailAddress")] OutsideParty outsideParty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outsideParty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(outsideParty);
        }

        // GET: OutsideParties/Delete/5
        public ActionResult Delete(int id)
        {
            OutsideParty outsideParty = db.OutsideParties.Find(id);
            if (outsideParty == null)
            {
                return HttpNotFound();
            }
            return View(outsideParty);
        }

        // POST: OutsideParties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OutsideParty outsideParty = db.OutsideParties.Find(id);
            db.OutsideParties.Remove(outsideParty);
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
