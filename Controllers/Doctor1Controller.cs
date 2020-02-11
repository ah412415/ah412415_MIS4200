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
    public class Doctor1Controller : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Doctor1
        public ActionResult Index()
        {
            return View(db.Doctor1.ToList());
        }

        // GET: Doctor1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor1 doctor1 = db.Doctor1.Find(id);
            if (doctor1 == null)
            {
                return HttpNotFound();
            }
            return View(doctor1);
        }

        // GET: Doctor1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctor1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "doctorID,doctorFirstName,doctorLastName,doctorSince,doctorSpecialty,doctorEmail,doctorPhone")] Doctor1 doctor1)
        {
            if (ModelState.IsValid)
            {
                db.Doctor1.Add(doctor1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctor1);
        }

        // GET: Doctor1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor1 doctor1 = db.Doctor1.Find(id);
            if (doctor1 == null)
            {
                return HttpNotFound();
            }
            return View(doctor1);
        }

        // POST: Doctor1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "doctorID,doctorFirstName,doctorLastName,doctorSince,doctorSpecialty,doctorEmail,doctorPhone")] Doctor1 doctor1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctor1);
        }

        // GET: Doctor1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor1 doctor1 = db.Doctor1.Find(id);
            if (doctor1 == null)
            {
                return HttpNotFound();
            }
            return View(doctor1);
        }

        // POST: Doctor1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doctor1 doctor1 = db.Doctor1.Find(id);
            db.Doctor1.Remove(doctor1);
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
