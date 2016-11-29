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
    }
}