namespace CodeFirstFromDB.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeMaster")]
    public partial class EmployeeMaster
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactNumber { get; set; }

        public string EmailId { get; set; }

        public int DesignationId { get; set; }

        public int SecurityQuestionId { get; set; }

        [Required]
        public string Answer { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(50)]
        public string BankAccountNumber { get; set; }

        [StringLength(20)]
        public string IFSCCode { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

        [StringLength(50)]
        public string BranchName { get; set; }

        public string PetName { get; set; }

        [StringLength(50)]
        public string EmpCode { get; set; }

        public virtual DesignationMaster DesignationMaster { get; set; }

        public virtual SecurityQuestionMaster SecurityQuestionMaster { get; set; }
    }
}
