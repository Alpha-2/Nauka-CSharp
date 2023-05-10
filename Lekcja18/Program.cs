using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja18
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int ile = 100;
            stopwatch.Start();
            BudujString(ile);
            stopwatch.Stop();
            Console.WriteLine("Standardowa metoda: {0} ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
            BudujStringBuilder(ile);
            ArrayList arrayList = new ArrayList();
            arrayList.Add("mam kota a ty nie");
            arrayList.Add(123);
            arrayList.Add("check list");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Yes but no tf
        /// </summary>
        /// <param name="ile">podaj podaj</param>
        /// <returns>stringa zwracamy</returns>
        public static string BudujString(int ile)
        {
            string tekst = "";
            for (int i = 0; i < ile; i++)
            {
                tekst += i;
            }
            return tekst;
        }

        /// <summary>
        /// no bat tanb
        /// </summary>
        /// <param name="ile"></param>
        /// <returns></returns>
        public static string BudujStringBuilder(int ile)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ile; i++)
            {
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
        }
    }
}