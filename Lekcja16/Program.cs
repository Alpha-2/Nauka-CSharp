using System;

namespace Lekcja16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci);
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci);
            Czlowiek man = new Czlowiek();
            Console.WriteLine(man.imie);
            Console.WriteLine(Czlowiek.liczbaLudnosci);
            Czlowiek.liczbaLudnosci = 10;
            Console.WriteLine(Czlowiek.liczbaLudnosci);
            Czlowiek.liczbaLudnosci = 1;
            Console.WriteLine(Czlowiek.liczbaLudnosci);
            Console.ReadKey();
        }
    }
}
