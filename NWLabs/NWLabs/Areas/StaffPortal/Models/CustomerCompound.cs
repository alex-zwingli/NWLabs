using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWLabs.Areas.StaffPortal.Models
{
    public class CustomerCompound
    {
        public Customer customer { get; set; }
        public Compound compound { get; set; }
    }
}