using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_20
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add("Bartłomiej");
            list.Add(new Auto("BMW"));
            list.RemoveAt(1);
            list.Insert(0, 0);
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list.Count);


            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Nazwa { get; set; }
        public Auto(string marka)   
        {
            Nazwa = marka;
        }
        public override string ToString()
        {
            return Nazwa;
        }
    }
}