﻿using NWLabs.Areas.StaffPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWLabs.Areas.StaffPortal.Controllers
{
    public class ReceivingController : Controller
    {
        // GET: StaffPortal/Receiving
        public ActionResult Index()
        {
            return View(); // Coming Soon
        }

        // Enter new compound information
        public ActionResult New()
        {
            CustomerCompound CustomerCompound = new CustomerCompound();

            return View(CustomerCompound);
        }
    }



}