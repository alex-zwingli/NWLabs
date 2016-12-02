using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWLabs.Areas.StaffPortal.Models
{
    public class Compound
    {
       
        [Key]
        [DisplayName("LT Number")]
        public int LTNumber { get; set; }

        [DisplayName("Compound Name")]
        public string compountName { get; set; }

        [DisplayName("Quantity")]
        public int Qty { get; set; }

        [DisplayName("Date Received")]
        public DateTime DateReceived { get; set; }

        [DisplayName("Received By")]
        public string ReceivedBy { get; set; }

        [DisplayName("Schedule Date")]
        public DateTime ScheduleDate { get; set; }

        [DisplayName("Actual Weight")]
        public double ActualWeight { get; set; }

        [DisplayName("MTD")]
        public string MTD { get; set; }

        [DisplayName("Animal")]
        public bool Animal { get; set; }
    }
}