namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewUser")]
    public partial class NewUser
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Age { get; set; }
    }
}
