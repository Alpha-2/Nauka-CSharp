using System;

namespace Lekcja14
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek("Arek", "Wódecki");
            adi.PrzedstawSie();
            Console.WriteLine(adi.nazwisko);
            adi.imie = "Bartek";
            adi.PrzedstawSie();

            Console.ReadKey();
        }
    }
}

