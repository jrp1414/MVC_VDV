using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst.DBLayer
{
    [Table("PODetail")]
    public class PurchaseDetail
    {
        [Key]
        public int SerialNumber { get; set; }

        public int PONumber { get; set; }

        [Required]
        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public double Rate { get; set; }

        public double Amount { get; set; }

        public PurchaseMaster PurchaseMaster { get; set; }
    }
}