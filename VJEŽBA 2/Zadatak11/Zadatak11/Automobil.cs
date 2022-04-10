using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak11
{
    internal class Automobil : Vozilo
    {
        public Automobil(string naziv, string tip)
        {
            this.Naziv = naziv;
            this.Tip = tip;
        }
    }
}
