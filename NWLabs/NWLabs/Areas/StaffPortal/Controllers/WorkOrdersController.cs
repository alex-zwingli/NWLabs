using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NWLabs.DAL;
using NWLabs.Areas.StaffPortal.Models;

namespace NWLabs.Areas.StaffPortal.Controllers
{
    public class WorkOrdersController : Controller
    {
        private NWLabsContext db = new NWLabsContext();

        // GET: StaffPortal/WorkOrders
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pending()
        {
            IEnumerable<WorkOrders> PendingOrders = db.Database.SqlQuery<WorkOrders>("SELECT * FROM WorOrder;");
     

            return View(PendingOrders);
        }

        public ActionResult Approved()
        {
            return View();
        }

        public ActionResult Completed()
        {
            return View();
        }

        public ActionResult Approve(int? WorkOrderNumber)
        {
            // Calculate possible discount

            return View(/*discount data, model*/);
        }


        // POST: Update record
        public ActionResult Finalize(int? WorkOrderNumber)
        {

            return View();
        }
    }
}