using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWLabs.Areas.ClientPortal.Controllers
{
    public class TicketsController : Controller
    {
        // GET: ClientPortal/Tickets
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tickets
        public ActionResult Tickets()
        {
            return View();
        }

        // GET: Ticket Details
        public ActionResult Details()
        {
            return View(); // Void
        }

        // GET: New Ticket
        public ActionResult New()
        {
            return View(); // Void
        }

        // POST: Ticket
    }
}