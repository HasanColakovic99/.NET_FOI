using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2.Models
{
    public class Transakcija
    {
        public Račun Platitelj;
        public Račun Primatelj;
        public double Iznos;

        public Transakcija(Račun platitelj, Račun primatelj, double iznos)
        {
            this.Platitelj = platitelj;
            this.Primatelj = primatelj;
            this.Iznos = iznos;
        }
    }
}
