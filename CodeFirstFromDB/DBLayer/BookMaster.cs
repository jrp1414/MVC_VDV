namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookMaster")]
    public partial class BookMaster
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string BookName { get; set; }

        [Required]
        [StringLength(50)]
        public string ISBNNumber { get; set; }

        [StringLength(50)]
        public string Publisher { get; set; }
    }
}
