using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja28.Postacie
{
    class Mag : Postac
    {
        public Mag(string imie, int punktyHP, int mana) : base(imie, punktyHP)
        {
            this.mana = mana;
        }

        public int mana;
    }
}