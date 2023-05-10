using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 11);
            int uN;

            do
            {
                Console.Write("Wpisz liczbę, z zakresu od 1 do 10: ");
                uN = int.Parse(Console.ReadLine());
            }
            while (uN != randomNumber);

            Console.ReadKey();
        }
    }
}
