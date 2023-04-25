using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SMDB.Attributes
{
    public class PasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var regex = new Regex("^[a-zA-Z0-9#*&!]*$");
            if(value.ToString().Contains(regex.ToString()))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Enter a Valid Password");
            }
            return base.IsValid(value, validationContext);
        }
    }
}
