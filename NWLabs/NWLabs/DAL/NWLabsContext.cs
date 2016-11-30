using NWLabs.Areas.StaffPortal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NWLabs.DAL
{
    public class NWLabsContext : DbContext
    {
        public NWLabsContext()
            : base("NWLabsContext")
        {

        }

        public DbSet<Customer> customer { get; set; }
        public DbSet<Compound> compound { get; set; }
        public DbSet<WorkOrders> WordOrders { get; set; }
    }
}