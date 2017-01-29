using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWLabs.Areas.StaffPortal.Models
{
    public class Test
    {
        [Key]
        public int TestID { get; set; }
        public string TestType { get; set; }
        public string TestName { get; set; }
    }
}