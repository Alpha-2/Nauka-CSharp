using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja32
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Dzielenie(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            Console.ReadKey();
        }

        static float Dzielenie(int a)
        {
            if (a == 5)
                throw new Exception("Nie dziel przez 5!");
            else if (a == 0)
                throw new Exception("Nie dzieli się przez 0!");

            return 10 / a;
        }
    }
}