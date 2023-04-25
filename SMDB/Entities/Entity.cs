using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMDB.Entities
{
    public class Entity
    {
        [Required]
        public string Name { get; set; }
        public double Weight { get; set; }
        public WeightType weightType { get; set; }
        public DateTimeOffset ExpireDate { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal Cost { get; set; }
        [Required]
        [Display(Name ="تعداد موجودی فعلی")]
        public long Number { get; set; }
        public string CompanyName { get; set; }
    }

    public enum WeightType
    {
        [Display(Name ="لیتر")]
        Liter,
        [Display(Name ="گرم")]
        Gramme,
        [Display(Name = "میلی لیتر")]
        MLiter,
        [Display(Name = "کیلو گرم")]
        KGramme,
        [Display(Name = "متر")]
        Meter,
        [Display(Name = "سانتی متر")]
        CMeter
    }
}
