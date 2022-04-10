using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba2
{
    public class Tečaj
    {
        public string Valuta;
        public double Tecaj;

        public Tečaj()
        {

        }
        public Tečaj(string valuta, double tecaj)
        {
            this.Valuta = valuta;
            this.Tecaj = tecaj;
        }
    }
}
