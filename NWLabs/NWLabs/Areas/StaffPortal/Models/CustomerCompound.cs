using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NWLabs.Areas.StaffPortal.Models
{
    public class CustomerCompound
    {
        public Customer customer { get; set; }
        public Compound compound { get; set; }
    }
}