using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja29
{
    class Program
    {
        static void Main(string[] args)
        {
            Postac p1 = new Postac("Elf", 2000);
            IAtakMagiczny atakMagiczny = (IAtakMagiczny)p1;
            atakMagiczny.Atak(2);

            Console.ReadKey();
        }
    }

    interface IAtakMagiczny
    {
        void Atak(int pkt);
    }

    interface IAtakMieczem
    {
        void Atak(int pkt);
    }

    class Postac : IAtakMagiczny, IAtakMieczem
    {
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }

        public string imie;
        public int punktyHP;

        void IAtakMagiczny.Atak(int pkt)
        {
            Console.WriteLine("tak");
        }

        void IAtakMieczem.Atak(int pkt)
        {
            Console.WriteLine("Nie");
        }
    }
}
