using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleMVC.Models
{
    public class EmployeeVM
    {
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string Answer { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string BankAccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string PetName { get; set; }
        public string EmpCode { get; set; }

        public string Designation { get; set; }

        public string Question { get; set; }
    }
}