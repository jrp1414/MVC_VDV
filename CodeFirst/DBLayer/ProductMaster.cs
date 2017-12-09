using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.DBLayer
{
    public class ProductMaster
    {
        public int Id { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public string Category { get; set; }

        public decimal UnitPrice { get; set; }
    }
}