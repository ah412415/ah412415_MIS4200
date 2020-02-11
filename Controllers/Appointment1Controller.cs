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
    public class Appointment1Controller : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Appointment1
        public ActionResult Index()
        {
            var appointment1 = db.Appointment1.Include(a => a.Doctor);
            return View(appointment1.ToList());
        }

        // GET: Appointment1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment1 appointment1 = db.Appointment1.Find(id);
            if (appointment1 == null)
            {
                return HttpNotFound();
            }
            return View(appointment1);
        }

        // GET: Appointment1/Create
        public ActionResult Create()
        {
            ViewBag.doctorID = new SelectList(db.Doctor1, "doctorID", "doctorFirstName");
            return View();
        }

        // POST: Appointment1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "appointment,appointmentID,DateTime,roomNumber,condition,doctorID")] Appointment1 appointment1)
        {
            if (ModelState.IsValid)
            {
                db.Appointment1.Add(appointment1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.doctorID = new SelectList(db.Doctor1, "doctorID", "doctorFirstName", appointment1.doctorID);
            return View(appointment1);
        }

        // GET: Appointment1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment1 appointment1 = db.Appointment1.Find(id);
            if (appointment1 == null)
            {
                return HttpNotFound();
            }
            ViewBag.doctorID = new SelectList(db.Doctor1, "doctorID", "doctorFirstName", appointment1.doctorID);
            return View(appointment1);
        }

        // POST: Appointment1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "appointment,appointmentID,DateTime,roomNumber,condition,doctorID")] Appointment1 appointment1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointment1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.doctorID = new SelectList(db.Doctor1, "doctorID", "doctorFirstName", appointment1.doctorID);
            return View(appointment1);
        }

        // GET: Appointment1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment1 appointment1 = db.Appointment1.Find(id);
            if (appointment1 == null)
            {
                return HttpNotFound();
            }
            return View(appointment1);
        }

        // POST: Appointment1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appointment1 appointment1 = db.Appointment1.Find(id);
            db.Appointment1.Remove(appointment1);
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
