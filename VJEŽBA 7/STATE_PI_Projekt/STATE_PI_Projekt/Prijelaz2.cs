using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class Prijelaz2 : Enumeracija
    {
        public Stanje Stanje { get; set; }
        public Dogadjaj Dogadjaj { get; set; }
        public Prijelaz2(Stanje stanje, Dogadjaj dogadjaj)
        {
            this.Stanje = stanje;
            this.Dogadjaj = dogadjaj;
        }

        public override bool Equals(object obj)
        {
            return obj is Prijelaz2 prijelaz &&
                   Stanje == prijelaz.Stanje &&
                   Dogadjaj == prijelaz.Dogadjaj;
        }

        public override int GetHashCode()
        {
            int hashCode = 32881769;
            hashCode = hashCode * -1521134295 + Stanje.GetHashCode();
            hashCode = hashCode * -1521134295 + Dogadjaj.GetHashCode();
            return hashCode;
        }
    }
}
