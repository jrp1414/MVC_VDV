namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StudentMaster
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public int? MobileNo { get; set; }

        [StringLength(10)]
        public string Class { get; set; }

        public int RollNo { get; set; }
    }
}
