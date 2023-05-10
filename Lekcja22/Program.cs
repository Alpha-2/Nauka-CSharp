using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Ania");
            dictionary.Add(2, "lll");
            if (!dictionary.ContainsKey(3))
            {
                dictionary.Add(3, "Marek");
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }
}
