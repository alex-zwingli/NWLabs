using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWLabs.Areas.ClientPortal.Controllers
{
    public class OrdersController : Controller
    {
        // GET: ClientPortal/Orders
        public ActionResult Index()
        {
            return View();
        }
    }
}