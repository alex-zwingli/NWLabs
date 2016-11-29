using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWLabs.Controllers
{
    [RoutePrefix("ClientPortal/AccountSummary")]
    public class AccountSummaryController : Controller
    {
        
        // GET: AccountSummary
        public ActionResult Index()
        {
            return View();
        }
    }
}