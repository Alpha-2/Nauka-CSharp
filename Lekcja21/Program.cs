using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Lekcja21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> list = new List<Auto>();
            list.Add(new Auto("BMW"));
            list.Add(new Auto("Man"));
            foreach (Auto item in list)
            {
                Console.WriteLine(item.Nazwa);
            }

            Console.ReadKey();
        }

        class Auto
        {
            public string Nazwa { get; set; }
            public Auto (string marka)
            {
                Nazwa = marka;
            }
            public void UruchomSilnik()
            {

            }
        }
    }
}
