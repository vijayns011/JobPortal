using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CustomAuthorizationFilter.Models;

namespace CustomAuthorizationFilter.Controllers
{
    public class JobDetailsController : Controller
    {
        private SqlDbContext db = new SqlDbContext();

        // GET: JobDetails
        public ActionResult Index()
        {
            return View(db.JobDetails.ToList());
        }

        // GET: JobDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobDetails jobDetails = db.JobDetails.Find(id);
            if (jobDetails == null)
            {
                return HttpNotFound();
            }
            return View(jobDetails);
        }

        // GET: JobDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,JobName,StartFrom,EndTo,TechnologiesUsed,Overview")] JobDetails jobDetails)
        {
            if (ModelState.IsValid)
            {
                db.JobDetails.Add(jobDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobDetails);
        }

        // GET: JobDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobDetails jobDetails = db.JobDetails.Find(id);
            if (jobDetails == null)
            {
                return HttpNotFound();
            }
            return View(jobDetails);
        }

        // POST: JobDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,JobName,StartFrom,EndTo,TechnologiesUsed,Overview")] JobDetails jobDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobDetails);
        }

        // GET: JobDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobDetails jobDetails = db.JobDetails.Find(id);
            if (jobDetails == null)
            {
                return HttpNotFound();
            }
            return View(jobDetails);
        }

        // POST: JobDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobDetails jobDetails = db.JobDetails.Find(id);
            db.JobDetails.Remove(jobDetails);
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
