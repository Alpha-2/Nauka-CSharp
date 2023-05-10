using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja31
{
    class Program
    {
        static void Main(string[] args)
        {
            // PoryRoku poraRoku = PoryRoku.Zima;
            Console.WriteLine(Enums.PoraRoku.PoryRoku.Zima);

            Console.ReadKey();
        }
    }
}
