using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWLabs.Areas.StaffPortal.Models
{
    public class Customer
    {
        [Key]
        public string ContactName { get; set; }
        public string OrganizationName { get; set; }
        public string CustEmail { get; set; }
    }
}