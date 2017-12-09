using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.DBLayer
{
    public class ERPDB : DbContext
    {
        public ERPDB() : base("name=ERPDB")
        {

        }
        public DbSet<PurchaseMaster> PurchaseMasters { get; set; }

        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }

        public DbSet<ProductMaster> ProductMaster { get; set; }

        public DbSet<EmployeeMaster> EmployeeMaster { get; set; }

    }
}