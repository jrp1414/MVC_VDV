namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BankData
    {
        [Key]
        public int BankId { get; set; }

        public string BankName { get; set; }

        public string TrnAmt { get; set; }

        public int AccountType { get; set; }

        [StringLength(50)]
        public string IFSCCode { get; set; }
    }
}
