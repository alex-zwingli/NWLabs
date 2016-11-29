using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWLabs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // About Page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // Service Page - Future


        // Industries Page - Future


        // Case Studies - Future


        // Articles - Future


        // R&D - Future


        // Pharma - Future


        // Catalog - Develope


        // Quote - Future


        // Contact - Develop



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}