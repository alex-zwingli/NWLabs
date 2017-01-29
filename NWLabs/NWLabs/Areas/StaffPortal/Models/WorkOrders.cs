using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWLabs.Areas.StaffPortal.Models
{
    public class WorkOrders
    {
        [Key]
        [DisplayName("Work Order Number")]
        public int WorkOrderNumber { get; set; }

        [DisplayName("Compound Type")]
        public string CompoundType { get; set; }

        [DisplayName("Compound Weight")]
        public string CompoundWeight { get; set; }

        [DisplayName("Receive Shipment")]
        public bool ReceiveShipment { get; set; }

        [DisplayName("Status")]
        public string status { get; set; }


    }
}