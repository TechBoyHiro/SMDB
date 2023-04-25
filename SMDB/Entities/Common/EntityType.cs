using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMDB.Entities.Common
{
    public class EntityType
    {
    }

    public enum HeaderType
    {
        [Display(Name ="کالا های اساسی و خوار و بار")]
        Grocery,
        [Display(Name ="لبنیات")]
        Dairy,
        Meat,
        BreakFast,
        Beverages,
        Canned,


    }
}
