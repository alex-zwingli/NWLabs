using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWLabs.Areas.ClientPortal.Controllers
{
    public class QuotesController : Controller
    {
        // GET: ClientPortal/Quotes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Request Quote
        public ActionResult RequestQuote()
        {
            return View(/*model*/);
        }

        // POST: Request Quote

        // GET: Pending Quote Requests
        public ActionResult PendingRequest()
        {
            return View();
        }

        // GET: Received Quotes
        public ActionResult ReceivedQuoted()
        {
            return View();
        }


    }
}