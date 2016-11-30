using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWLabs.Areas.StaffPortal.Models
{
    public class WorkOrders
    {
        [Key]
        public int WorkOrderNumber { get; set; }
        public string CompoundType { get; set; }
        public string CompoundWeight { get; set; }
        public bool ReceiveShipment { get; set; }
        public string status { get; set; }
    }
}