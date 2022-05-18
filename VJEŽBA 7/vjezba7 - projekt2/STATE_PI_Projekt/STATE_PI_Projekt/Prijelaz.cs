using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class Prijelaz : EnumeracijaProjekta
    {
        public Stanje Stanje { get; set; }
        public Dogadaj Dogadaj { get; set; }
        public Prijelaz(Stanje trenutnoStanje, Dogadaj aktivacijskiDogadaj)
        {
            this.Stanje = trenutnoStanje;
            this.Dogadaj = aktivacijskiDogadaj;
        }

        public override bool Equals(object obj)
        {
            return obj is Prijelaz prijelaz &&
                   Stanje == prijelaz.Stanje &&
                   Dogadaj == prijelaz.Dogadaj;
        }

        public override int GetHashCode()
        {
            int hashCode = 847282615;
            hashCode = hashCode * -1521134295 + Stanje.GetHashCode();
            hashCode = hashCode * -1521134295 + Dogadaj.GetHashCode();
            return hashCode;
        }
    }
}
