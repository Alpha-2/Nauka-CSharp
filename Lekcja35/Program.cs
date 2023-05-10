using System;
using System.IO;
using System.Net.Http.Headers;

namespace Lekcja35
{
    class Program
    {
        static void Main(string[] args)
        {
            string _path = @"plik.txt";
            StreamWriter sw;

            if (File.Exists(_path))
            {
                sw = File.CreateText(_path);
                Console.WriteLine("tak");
            }
            else
            {
                sw = new StreamWriter(_path, true);
                Console.WriteLine("Plik został otwarty");
            }
            Console.Write("Podaj tekst: ");
            string _tekst = Console.ReadLine();
            sw.Write(_tekst);
            sw.Close();

            StreamReader sr = File.OpenText(_path);
            string s = "";
            int i = 1;
            Console.WriteLine("\nZawartość pliku: ");
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + ". " + s);
            }
            sr.Close();

            Console.ReadKey();
        }
    }
}
