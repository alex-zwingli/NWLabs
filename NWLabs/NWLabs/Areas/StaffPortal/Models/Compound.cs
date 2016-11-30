using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWLabs.Areas.StaffPortal.Models
{
    public class Compound
    {
       
        [Key]
        public int LTNumber { get; set; }
        public string compountName { get; set; }
        public int Qty { get; set; }
        public DateTime DateReceived { get; set; }
        public string ReceivedBy { get; set; }
        public DateTime ScheduleDate { get; set; }
        public double ActualWeight { get; set; }
        public string MTD { get; set; }
        public bool Animal { get; set; }
    }
}