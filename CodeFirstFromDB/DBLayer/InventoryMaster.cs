namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryMaster")]
    public partial class InventoryMaster
    {
        [Key]
        public int InventoryId { get; set; }

        [StringLength(10)]
        public string Name { get; set; }
    }
}
