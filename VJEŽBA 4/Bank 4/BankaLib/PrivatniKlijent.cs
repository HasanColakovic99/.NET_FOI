using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class PrivatniKlijent : Klijent
    {
        public override string Opis
        {
            get
            {
                return Osoba.Ime + " " + Osoba.Prezime;
            }
        }

        public PrivatniKlijent(string oib, string ime, string prezime)
            :base(oib, ime, prezime)
        {
            Tip = TipKlijenta.Privatni;
            Osoba = new  Osoba(oib, ime, prezime);
        }

        public override string ToString()
        {
            return Osoba.Ime + " " + Osoba.Prezime; 
        }
    }
}
