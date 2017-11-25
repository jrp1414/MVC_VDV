namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExpenseMaster")]
    public partial class ExpenseMaster
    {
        [Key]
        public int ExpenseId { get; set; }

        [Required]
        [StringLength(10)]
        public string CostCenter { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
