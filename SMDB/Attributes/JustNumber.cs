using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SMDB.Attributes
{
    public class JustNumber : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var regex = new Regex("^[a-zA-Z]*$");
            if (value.ToString().Contains(regex.ToString()))
            {
                return new ValidationResult("");
            }
            else
                return ValidationResult.Success;
        }
    }
}
