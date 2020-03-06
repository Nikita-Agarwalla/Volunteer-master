using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Volunteer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Contact");
        }
        public ActionResult Contact1()
        {
            return View();
        }
        public ActionResult CreateEvent()
        {
            return View();
        }
        public ActionResult Volunteer()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Organizer()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult dashboard()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}