using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthorizationFilter.Controllers
{
    public class EmployeeProfileController : Controller
    {
        // GET: EmployeeProfile
        public ActionResult Index()
        {
            return View();
        }
    }
}