using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja28
{
    class Program
    {
        static void Main(string[] args)
        {
            Postacie.Mag p1 = new Postacie.Mag("Elf", 200, 50);
            Console.WriteLine(p1.imie + " " + p1.punktyHP + " " + p1.mana);
            
            Console.ReadKey();
        }
    }
}