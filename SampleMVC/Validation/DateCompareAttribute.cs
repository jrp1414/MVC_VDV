using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleMVC.Validation
{
    public class DateCompareAttribute : ValidationAttribute
    {
        public string OtherPropName { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var modelType = validationContext.ObjectInstance.GetType();
            var otherProdInfo = modelType.GetProperty(OtherPropName);
            var otherPropVal = Convert.ToDateTime(otherProdInfo.GetValue(validationContext.ObjectInstance));
            var val = Convert.ToDateTime(value);
            if (val < otherPropVal)
            {
                return new ValidationResult("Start Date should be less than end date");
            }
            return ValidationResult.Success;
        }
    }
}