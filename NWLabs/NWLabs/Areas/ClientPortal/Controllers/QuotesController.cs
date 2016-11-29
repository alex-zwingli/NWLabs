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
        // This view provides all quote related options to user
        public ActionResult Index()
        {
            return View();
        }

        // GET: RequestQuote
        // Client fills out form to request quote
        public ActionResult RequestQuote ()
        {
            return View();
        }

        // GET: PendingRequests
        // Client views status and details of all pending quote requests
        public ActionResult PendingRequests ()
        {
            return View();
        }

    }
}