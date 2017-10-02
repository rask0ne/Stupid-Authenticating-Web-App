using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.Ajax.Utilities;
using Stupid_Authenticating_Web_App.Models;

namespace Stupid_Authenticating_Web_App.Controllers
{
    [RequireHttps]
    [Authorize]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                users = db.Users.ToList();
            }
            ViewBag.users = users;
            return View();
        }

        [Authorize(Roles = "user")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}