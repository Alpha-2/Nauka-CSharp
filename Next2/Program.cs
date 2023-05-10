using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numberList = new int[200];
            string[] stringList = { "pociąg", "pociąg2", "zero" };

            for (int i = 0; i < stringList.Length; i++)
            {
                Console.WriteLine(stringList[i]);
            }

            Console.ReadLine();
        }
    }
}
