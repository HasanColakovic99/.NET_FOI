using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10.Models
{
    public class Tečaj
    {
        public string Valuta;
        public double TecajValute;

        public Tečaj(string valuta, double tecajValute)
        {
            this.Valuta = valuta;
            this.TecajValute = tecajValute;
        }
    }
}
