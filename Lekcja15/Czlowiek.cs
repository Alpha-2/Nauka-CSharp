using System;

namespace Lekcja14
{
    class Czlowiek
    {
        public Czlowiek(string imieKonstruktora, string nazwiskoKonstruktora)
        {
            imie = imieKonstruktora;
            nazwisko = nazwiskoKonstruktora;
        }
        public string imie = "BRAK";
        public string nazwisko = "BRAK";

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imię " + imie);
        }
    }
}
