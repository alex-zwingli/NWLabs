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
        public new ActionResult Request()
        {
            return View(/*model*/);
        }

        // POST: Request Quote

        // GET: Pending Quote Requests
        public ActionResult Pending()
        {
            return View();
        }

        // GET: Received Quotes
        public ActionResult Quotes()
        {
            return View();
        }

        // GET: Quote details
        public ActionResult Details()
        {
            return View(); //void
        }


    }
}