using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWLabs.Areas.StaffPortal.Models
{
    public class Customer
    {
        [Key]
        [DisplayName("Contact Name")]
        public string ContactName { get; set; }

        [DisplayName("Organization Name")]
        public string OrganizationName { get; set; }

        [DisplayName("Customer Email")]
        public string CustEmail { get; set; }
    }
}