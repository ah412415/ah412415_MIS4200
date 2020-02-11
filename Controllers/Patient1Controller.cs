using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ah412415_MIS4200.Models;
using ah412415_MIS4200.Models.DAL;

namespace ah412415_MIS4200.Controllers
{
    public class Patient1Controller : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Patient1
        public ActionResult Index()
        {
            return View(db.Patient1.ToList());
        }

        // GET: Patient1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient1 patient1 = db.Patient1.Find(id);
            if (patient1 == null)
            {
                return HttpNotFound();
            }
            return View(patient1);
        }

        // GET: Patient1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patient1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "patientID,pateintID,patientFirstName,patientLastName,patientPhone,patientCondition,patientSince")] Patient1 patient1)
        {
            if (ModelState.IsValid)
            {
                db.Patient1.Add(patient1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patient1);
        }

        // GET: Patient1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient1 patient1 = db.Patient1.Find(id);
            if (patient1 == null)
            {
                return HttpNotFound();
            }
            return View(patient1);
        }

        // POST: Patient1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "patientID,pateintID,patientFirstName,patientLastName,patientPhone,patientCondition,patientSince")] Patient1 patient1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patient1);
        }

        // GET: Patient1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient1 patient1 = db.Patient1.Find(id);
            if (patient1 == null)
            {
                return HttpNotFound();
            }
            return View(patient1);
        }

        // POST: Patient1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patient1 patient1 = db.Patient1.Find(id);
            db.Patient1.Remove(patient1);
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
