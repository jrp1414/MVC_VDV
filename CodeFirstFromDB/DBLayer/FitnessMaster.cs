namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FitnessMaster")]
    public partial class FitnessMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FitnessDataId { get; set; }

        [StringLength(50)]
        public string FitnessDataName { get; set; }
    }
}
