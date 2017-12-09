namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CountryMaster")]
    public partial class CountryMaster
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
