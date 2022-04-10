using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public abstract class Klijent : IKlijent
    {
        public abstract string Opis { get; }
        public TipKlijenta Tip { get; protected set; }
        public Osoba Osoba { get; set; }

        public Klijent(string oib, string ime, string prezime)
        {
            Osoba = new Osoba(oib, ime, prezime);
        }
    }
}
