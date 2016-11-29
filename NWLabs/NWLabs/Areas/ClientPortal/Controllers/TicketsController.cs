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

        // GET: Ticket
        // Returns ticket details
        public ActionResult Ticket(int id)
        {
            return View();
        }

        // GET: NewTicket
        // Displays form for client to submit new ticket
        public ActionResult NewTicket()
        {
            return View();
        }
    }
}