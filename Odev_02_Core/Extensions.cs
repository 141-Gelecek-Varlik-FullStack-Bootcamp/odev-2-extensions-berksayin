using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Odev_02_Core
{
    public static class Extensions
    {
        //Calculating today's USD to TRY
        public static string ToTRY(this double _variable, DateTime _date)
        {
            return _date + " Tarihli Kura Göre: " + Convert.ToString(_variable * 13.40) + " TRY";
        }

        //Calculating tomorrow's USD to TRY
        public static string ToTRYTomorrow(this double _variable, DateTime _date)
        {
            return _date + " Tarihli Kura Göre: " + Convert.ToString(_variable * 14.00) + " TRY";
        }

        //Calculating today's USD to EUR
        public static string ToEUR(this double _variable, DateTime _date)
        {
            return _date + " Tarihli Kura Göre: " + Convert.ToString(_variable * 0.88) + " EUR";
        }

        //Getting attributes
        public static string GetCurrencies(this Enum currencyType)
        {
            var result = currencyType.GetType().GetMember(currencyType.ToString()).First().GetCustomAttributes<DisplayAttribute>().First().Name + " __ " +
                         currencyType.GetType().GetMember(currencyType.ToString()).First().GetCustomAttributes<DisplayAttribute>().First().ShortName + " __ " +
                         currencyType.GetType().GetMember(currencyType.ToString()).First().GetCustomAttributes<DisplayAttribute>().First().Description;
            return result.ToString();
        }

        //Getting types
        public static int GetCurrencyType(this Enum currencyType)
        {
            return Convert.ToInt32(currencyType);
        }
    }
}
