using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class Osoba
    {
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string oib, string ime, string prezime)
        {
            OIB = oib;
            Ime = ime;
            Prezime = prezime;
        }

        public override string ToString()
        {
            return OIB+" "+ Ime + " " + Prezime;
        }
    }
}
