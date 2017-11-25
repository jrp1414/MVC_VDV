namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransactionMaster")]
    public partial class TransactionMaster
    {
        [Key]
        public int TransactionId { get; set; }

        [StringLength(50)]
        public string TransText { get; set; }

        [StringLength(50)]
        public string TransDetails { get; set; }
    }
}
