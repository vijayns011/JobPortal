using CustomAuthorizationFilter.Infrastructure;
using CustomAuthorizationFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthorizationFilter.Controllers
{
    [CustomAuthorize("Admin", "SuperAdmin")]
    public class EmployeeProfileController : Controller
    {
        private SqlDbContext db = new SqlDbContext();

        // GET: EmployeeProfile
        public ActionResult Index()
        {
            if (Session["UserId"] != null)
            {
                var userId = Session["UserId"].ToString();
                var usr = (from user in db.Users where user.UserId == userId select user).ToList<User>();
                //db.Users.Select(s => s.UserId == Session["UserId"].ToString()).ToList<User>();
                var UserId = usr[0].Id;
                List<JobSeeker> jobSeekerLst = (from jbSkr in db.JobSeekers where jbSkr.UserId == UserId select jbSkr).ToList<JobSeeker>();
                if (jobSeekerLst.Count > 0)
                {
                    return View(jobSeekerLst[0]);
                }

            }
            return View();
        }

       
        
        public ActionResult SaveBasicDetails(JobSeeker jobSeeker)
        {
            if (ModelState.IsValid)
            {
                if (Session["UserId"] != null)
                {
                    var userId = Session["UserId"].ToString();
                    var usr = (from user in db.Users where user.UserId == userId select user).ToList<User>();
                    jobSeeker.UserId = usr[0].Id;
                    jobSeeker.UpdatedDate = DateTime.Now;
                    jobSeeker.CreatedDate = DateTime.Now;


                }
                    db.JobSeekers.Add(jobSeeker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobSeeker);
        }
    }
}