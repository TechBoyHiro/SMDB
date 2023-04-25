using EntityType.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityType.HeaderType
{
    class Meat : BaseEntityType
    {
        public MeatType Type { get; set; }
        public string Detalis { get; set; }
    }

    public enum MeatType
    {
        [Display(Name ="گوشت گاو و گوساله")]
        Beef,
        [Display(Name ="گوشت مرغ")]
        Chicken,
        [Display(Name = "تخم مرغ")]
        Egg,
        [Display(Name = "ماهی, میگو و خاویار")]
        SeaFood,
        [Display(Name = "سوسیس و کالباس")]
        Sausage,
        [Display(Name = "گوشت گوسفندی")]
        LambMeat
    }
}
