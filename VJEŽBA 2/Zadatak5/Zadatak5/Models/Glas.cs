using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5.Models
{
    public class Glas
    {
        public string OIB;
        public string Odabir;

        // KONSTRUKTOR KLASE GLAS
        public Glas(string oib, string odabir)
        {
            this.OIB = oib;
            this.Odabir = odabir;
        }
    }
}
