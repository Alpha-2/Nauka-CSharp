using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_16_5
{
    class Czlowiek
    {
        public string imie;

        private int wiek;

        public int Wiek
        {
            get
            {
                return wiek;
            }
            set
            {
                if (value >= 0 && value <= 200)
                    wiek = value;
                else
                    wiek = 0;
            }
        }
        private string tak;

        public string MTak
        {
            get
            {
                return tak;
            }
            set
            {
                if (value != "Tak")
                    tak = value;
                else
                    tak = "nie";
            }
        }


    }
}
