using System;

namespace Lekcja34
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze zwierze = new Zwierze();
            Kot kot = new Kot();
            zwierze = new Kot();

            kot = (Kot)zwierze;
            Console.WriteLine(kot is Kot);

            Console.ReadKey();
        }
    }

    class Zwierze
    {
        public void DajGlos()
        {
            Console.WriteLine("Domyslny glos");
        }
    }

    class Kot : Zwierze
    {
        public void PijMleko()
        {
            Console.WriteLine("Pije mleko");
        }
    }
}
