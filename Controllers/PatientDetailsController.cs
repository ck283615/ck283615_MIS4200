using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ck283615_MIS4200.DAL;
using ck283615_MIS4200.Models;

namespace ck283615_MIS4200.Controllers
{
    public class PatientDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: PatientDetails
        public ActionResult Index()
        {
            var patientDetails = db.PatientDetails.Include(p => p.Operation).Include(p => p.Patient);
            return View(patientDetails.ToList());
        }

        // GET: PatientDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientDetail patientDetail = db.PatientDetails.Find(id);
            if (patientDetail == null)
            {
                return HttpNotFound();
            }
            return View(patientDetail);
        }

        // GET: PatientDetails/Create
        public ActionResult Create()
        {
            ViewBag.operationID = new SelectList(db.Operations, "operationID", "operationDescription");
            ViewBag.patientID = new SelectList(db.Patients, "patientID", "fullName");
            
            
            return View();
        }

        // POST: PatientDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "patientdetailID,insuranceCompany,amountOwed,patientID,operationID")] PatientDetail patientDetail)
        {
            if (ModelState.IsValid)
            {
                db.PatientDetails.Add(patientDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.operationID = new SelectList(db.Operations, "operationID", "operationDescription");
            ViewBag.patientID = new SelectList(db.Patients, "patientID", "fullName");
            return View(patientDetail);
        }

        // GET: PatientDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientDetail patientDetail = db.PatientDetails.Find(id);
            if (patientDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.operationID = new SelectList(db.Operations, "operationID", "operationDescription");
            ViewBag.patientID = new SelectList(db.Patients, "patientID", "fullName");
            return View(patientDetail);
        }

        // POST: PatientDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "patientdetailID,insuranceCompany,amountOwed,patientID,operationID")] PatientDetail patientDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.operationID = new SelectList(db.Operations, "operationID", "operationDescription");
            ViewBag.patientID = new SelectList(db.Patients, "patientID", "fullName");
            return View(patientDetail);
        }

        // GET: PatientDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientDetail patientDetail = db.PatientDetails.Find(id);
            if (patientDetail == null)
            {
                return HttpNotFound();
            }
            return View(patientDetail);
        }

        // POST: PatientDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientDetail patientDetail = db.PatientDetails.Find(id);
            db.PatientDetails.Remove(patientDetail);
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
