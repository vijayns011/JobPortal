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
    public class EducationDetailsController : Controller
    {
        private SqlDbContext db = new SqlDbContext();

        // GET: EducationDetails
        public ActionResult Index()
        {
            return View(db.EducationDetails.ToList());
        }

        // GET: EducationDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationDetails educationDetails = db.EducationDetails.Find(id);
            if (educationDetails == null)
            {
                return HttpNotFound();
            }
            return View(educationDetails);
        }

        // GET: EducationDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EducationDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EducationName,ManthAndYearOfPassing,Percentage")] EducationDetails educationDetails)
        {
            if (ModelState.IsValid)
            {
                db.EducationDetails.Add(educationDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(educationDetails);
        }

        // GET: EducationDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationDetails educationDetails = db.EducationDetails.Find(id);
            if (educationDetails == null)
            {
                return HttpNotFound();
            }
            return View(educationDetails);
        }

        // POST: EducationDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EducationName,ManthAndYearOfPassing,Percentage")] EducationDetails educationDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(educationDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(educationDetails);
        }

        // GET: EducationDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationDetails educationDetails = db.EducationDetails.Find(id);
            if (educationDetails == null)
            {
                return HttpNotFound();
            }
            return View(educationDetails);
        }

        // POST: EducationDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EducationDetails educationDetails = db.EducationDetails.Find(id);
            db.EducationDetails.Remove(educationDetails);
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
