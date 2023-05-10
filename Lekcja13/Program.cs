using System;

namespace Lekcja14
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek();
            Console.WriteLine(adi.imie);
            adi.imie = "przemyslaw";
            Console.WriteLine(adi.imie);

            Czlowiek adi2 = new Czlowiek();
            Console.WriteLine(adi2.imie);
            adi.PrzedstawSie();
            adi2.PrzedstawSie();
            
            Console.ReadKey();
        }
    }
}

