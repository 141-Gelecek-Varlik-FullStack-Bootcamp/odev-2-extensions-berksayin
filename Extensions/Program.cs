using System;

namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For displaying symbols correctly.
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            DateTime date = DateTime.Now;
            double currency = 1.00;

            //Calculate the currencies
            Console.WriteLine("1 Dolar = " + Odev_02_Core.Extensions.ToTRY(currency, date));
            Console.WriteLine("1 Dolar = " + Odev_02_Core.Extensions.ToTRYTomorrow(currency, date.AddDays(1)));
            Console.WriteLine("1 Dolar = " + Odev_02_Core.Extensions.ToEUR(currency, date));

            Console.WriteLine();

            //Reflection currencies
            Console.WriteLine("Types Of Currencies");
            Console.WriteLine(Odev_02_Core.Extensions.GetCurrencies(CurrencyType.CurrencyTypeDollar) + " Type Code: " + Odev_02_Core.Extensions.GetCurrencyType(CurrencyType.CurrencyTypeDollar));
            Console.WriteLine(Odev_02_Core.Extensions.GetCurrencies(CurrencyType.CurrencyTypeEuro) + " Type Code: " + Odev_02_Core.Extensions.GetCurrencyType(CurrencyType.CurrencyTypeEuro));
            Console.WriteLine(Odev_02_Core.Extensions.GetCurrencies(CurrencyType.CurrencyTypeLira) + " Type Code: " + Odev_02_Core.Extensions.GetCurrencyType(CurrencyType.CurrencyTypeLira));
        }
    }
}
