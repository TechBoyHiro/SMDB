using EntityType.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityType.HeaderType
{
    class Dairy : BaseEntityType
    {
        public DairyType Type { get; set; }
        public string Details { get; set; }
    }

    public enum DairyType
    {
        [Display(Name ="شیر")]
        Milk,
        [Display(Name = "کره حیوانی و گیاهی")]
        Butter,
        [Display(Name = "دوغ")]
        Doogh,
        [Display(Name = "ماست")]
        Yoghurt,
        [Display(Name = "کشک")]
        Curd,
        [Display(Name = "خامه")]
        Cream,
        [Display(Name = "پنیر")]
        Cheese,
        [Display(Name = "دسر آماده")]
        ReadyDessert
    }
}
