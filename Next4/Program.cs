using System;


class Program
{
    static void Main(string[] args)
    {
        Template(2, 4, "Imię: ");
        Console.ReadKey();
    }

    static void Template(int a, int b, string Michal)
    {
        int wynik = a + b;

        Console.Write("Wynik: " + Michal + wynik);
    }

}