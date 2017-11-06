using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Models
{
    public class StudentData
    {
        public StudentData()
        {
            Cities = new List<SelectListItem>
            {
                new SelectListItem{ Text="Pune", Value="1"  },
                new SelectListItem{ Text="Mumbai", Value="2" },
                new SelectListItem{ Text="Delhi", Value="3" },
                new SelectListItem{ Text="Chennai", Value="4" }
            };

            Skills = new List<SelectListItem>
            {
                new SelectListItem{ Text="C#", Value="1"  },
                new SelectListItem{ Text="ASP.Net", Value="2" },
                new SelectListItem{ Text="Angular", Value="3" },
                new SelectListItem{ Text="Javascript", Value="4" }
            };
        }
        public int Id { get; set; }

        [RegularExpression(@"^[A-Za-z]+$",ErrorMessage ="Please enter valid name")]
        [StringLength(20,MinimumLength =2,ErrorMessage ="Name should be between 2 to 20 charachters")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please enter Name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Address")]
        public string Address { get; set; }

        [Range(6,25,ErrorMessage ="Age should be between 6 to 25" )]
        public int Age { get; set; }

        [Display(Name="City")]
        [Required]
        public int SelectedCity { get; set; }

        public List<SelectListItem> Cities { get; set; }

        [Required]
        [Display(Name = "Skills")]
        public string[] SelectedSkills { get; set; }

        public List<SelectListItem> Skills { get; set; }

        public int Gender { get; set; }

        [Display(Name = "Is Adult")]
        public bool IsAdult { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("ConfirmPassword")]
        [Required]
        public string Password { get; set; }

        [Required]        
        public string ConfirmPassword { get; set; }

        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}