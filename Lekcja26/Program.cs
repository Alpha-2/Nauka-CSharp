using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja26
{
    class Program
    {
        static void Main(string[] args)
        {
            Ziemia ziemia = new Ziemia();
            ziemia.Nazwa = "Mars";
            Console.WriteLine(ziemia.Nazwa);
            ziemia.Atmosfera();
            ziemia.PoraDniaINocy();
            ziemia.RuchObrotowy();

            Console.ReadKey();
        }
    }

    abstract class CialoNiebieskie
    {
        public string Nazwa { get; set; }

        public void RuchObrotowy()
        {
            Console.WriteLine("Każde ciało niebieskie ma ruch obrotowy");
        }
    }

    abstract class Planeta : CialoNiebieskie
    {
        public void PoraDniaINocy()
        {
            Console.WriteLine("Pory dnia i nocy");
        }
    }

    class Ziemia : Planeta
    {
        public void Atmosfera()
        {
            Console.WriteLine("Atmosfera ziemska");
        }
    }

    class Mars : Planeta
    {
        public void Yes()
        {
            Console.WriteLine("yes");
        }
    }
}