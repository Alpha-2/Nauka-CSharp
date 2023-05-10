using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja25
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Fiat", 1999);
            Auto auto2 = new Auto("Mercedes", 1995);
            Auto auto3 = new Auto("Man", 1989);
            Auto auto4 = new Auto("Skoda", 1999);
            Auto auto5 = new Auto("BMW", 2015);
            List<Auto> list = new List<Auto>();
            list.Add(auto1);
            list.Add(auto2);
            list.Add(auto3);
            list.Add(auto4);
            list.Add(auto5);

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item.Rocznik + " - " + item.Model);
            }
            Console.ReadKey();
        }
    }

    class Auto : IComparable
    {
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public string Name { get; set; }
        public Auto(string Model, int Rocznik)
        {
            this.Model = Model;
            this.Rocznik = Rocznik;
        }

        public int CompareTo(object obj)
        {
            var arg = (Auto)obj;
            if (Rocznik < arg.Rocznik)
                return 1;
            else if (Rocznik > arg.Rocznik)
                return 0;
            else
                return -1;
        }
    }
}
