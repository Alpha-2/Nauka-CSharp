using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lekcja_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //var c = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //foreach (var item in c)
            //{
            //    Console.Write(item.Name);
            //    Console.WriteLine(item.NumberFormat.NumberDecimalSeparator);
            //}

            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            newCulture.NumberFormat.NumberDecimalSeparator = ":";
            CultureInfo.CurrentCulture = newCulture;

            int a = -5;
            float b = 3.14f;
            Console.WriteLine($"tak {a}\nale nie {b}");

            Console.ReadKey();
        }
    }
}
