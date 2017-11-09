using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleMVC.Validation
{
    public class DOBAttribute : ValidationAttribute
    {
        private int year;
        public DOBAttribute(int _year)
        {
            year = _year;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dob = Convert.ToDateTime(value);
            if (dob.Year < year)
            {
                return new ValidationResult(string.Format("Year should be greater than or equals to {0}", year));
            }
            return ValidationResult.Success;
        }
    }
}