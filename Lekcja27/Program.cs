using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja27
{
    class Program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("Elf", 200, 50);
            Console.WriteLine(p1.imie + " " + p1.punktyHP + " " + p1.mana);

            Console.ReadKey();
        }
    }

    abstract class Postac
    {
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }

        public string imie;
        public int punktyHP;
    }

    class Mag : Postac
    {
        public Mag(string imie, int punktyHP, int mana) : base (imie, punktyHP)
        {
            this.mana = mana;
        }

        public int mana;
    }
}