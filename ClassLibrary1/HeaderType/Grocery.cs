using EntityType.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityType.HeaderType
{
    [Display(Name="کالا های اساسی و خوار و بار")]
    class Grocery : BaseEntityType
    {
        public GroceryType Type { get; set; }
        public string Details { get; set; }
    }

    public enum GroceryType
    {
        [Display(Name ="برنج")]
        Rice,
        [Display(Name = "روغن")]
        Oil,
        [Display(Name = "قند و نبات")]
        SugarLoaf,
        [Display(Name = "شکر")]
        Sugary,
        [Display(Name = "حبوبات و سویا")]
        Soya,
        [Display(Name = "ماکارونی , پاستا و رشته")]
        Pasta,
        [Display(Name = "سس")]
        Sauce,
        [Display(Name = "رب و کنسرو گوجه فرنگی")]
        TomatoCanned,
        [Display(Name = "چاشنی های مایع ترش")]
        Vinegar,
        [Display(Name = "غلات")]
        Cereals,
        [Display(Name = "ادویه و چاشنی")]
        Spices,
        [Display(Name = "زعفران,زرشک و تزئینات غذا")]
        Saffron,
        [Display(Name = "سبزی خشک و پودر جوانه")]
        DriedHerbs,
        [Display(Name = "دسر")]
        Dessert,
        [Display(Name = "خیارشور و ترشیجات")]
        Pickles,
        [Display(Name = "زیتون")]
        Olive,
        [Display(Name = "خمیر")]
        Dough
    }
}
