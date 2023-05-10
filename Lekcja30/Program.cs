using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja30
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt2D punkt1 = new Punkt2D();
            punkt1.y = 5;
            punkt1.x = 4;
            Punkt2D punkt2;
            punkt2.x = 3;

            Console.WriteLine(punkt2.x);
            Console.WriteLine(punkt1.y);

            Console.ReadKey();
        }
    }

    struct Punkt2D
    {
        public static Punkt2D operator +(Punkt2D a, Punkt2D b)
        {
            return new Punkt2D(a.x + b.x, a.y + b.y);
        }
        public Punkt2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
        public double OdlegloscOdSrodka()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)), 1);
        }
    }
}
