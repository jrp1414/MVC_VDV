using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.DBLayer
{
    public class PurchaseMaster
    {
        public PurchaseMaster()
        {
            PurchaseDetail = new HashSet<PurchaseDetail>();
        }
        [Key]
        public int PONumber { get; set; }

        [Required]
        [StringLength(20)]
        public string SupplierCode { get; set; }

        public DateTime Date { get; set; }

        public ICollection<PurchaseDetail> PurchaseDetail { get; set; }
    }
}