using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWLabs.Areas.StaffPortal.Controllers
{
    public class InvoicingController : Controller
    {
        // GET: StaffPortal/Invoicing
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult All()
        {
            return View();
        }

        public ActionResult Pending()
        {
            return View();
        }

        public ActionResult Outstanding()
        {
            return View();
        }

        public ActionResult Billing()
        {
            return View();
        }
    }
}