using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public enum CurrencyType
    {
        //Assigning names, symbols and types of currencies
        [Display(Name = "Dollar", ShortName = "USD", Description = "$")]
        CurrencyTypeDollar = 1,
        [Display(Name = "Euro", ShortName = "EUR", Description = "€")]
        CurrencyTypeEuro = 2,
        [Display(Name = "Lira", ShortName = "TRY", Description = "₺")]
        CurrencyTypeLira = 3
    }
}
