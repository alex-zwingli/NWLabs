using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWLabs.Areas.ClientPortal.Controllers
{
    public class MessageCenterController : Controller
    {
        // GET: ClientPortal/MessageCenter
        // Returns list of all messgaes and options
        public ActionResult Index()
        {
            return View();
        }

        // GET: Message
        // Returns message details
        public ActionResult Message()
        {
            return View();
        }

    }
}