using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.DBLayer
{
    public class POMasterDetail
    {
        public int PONumber { get; set; }

        public string SupplierCode { get; set; }

        public DateTime Date { get; set; }

        public int SerialNumber { get; set; }

        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public double Rate { get; set; }

        public double Amount { get; set; }
    }
}