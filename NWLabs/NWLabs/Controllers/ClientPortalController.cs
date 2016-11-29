using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWLabs.Controllers
{
    public class ClientPortalController : Controller
    {
        // GET: ClientPortal
        public ActionResult Index()
        {
            return RedirectToAction("AccountSummary");
        }

        // Account Summary

        //public ActionResult AccountSummary()
        //{
        //    return RedirectToAction("Index", "AccountSummary");
        //}

        // Quotes - Future
        public ActionResult Quotes()
        {
            return RedirectToAction("Account Summary");
        }

        // Tickets - Future
        public ActionResult Tickets()
        {
            return RedirectToAction("Account Summary");
        }

        // Orders - Develop
        public ActionResult Orders()
        {
            return RedirectToAction("Account Summary");
        }

        // Reports - Develop
        public ActionResult Reports()
        {
            return RedirectToAction("Account Summary");
        }

        // Refferals - Future
        public ActionResult Refferals()
        {
            return RedirectToAction("Account Summary");
        }

        // Billing - Develop
        public ActionResult Billing()
        {
            return RedirectToAction("Account Summary");
        }

        // Message Center - Future
        public ActionResult MessageCenter()
        {
            return RedirectToAction("Account Summary");
        }

        // Profile - Future
        public ActionResult Profile()
        {
            return RedirectToAction("Account Summary");
        }




    }
}