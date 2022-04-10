using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class PoslovniKlijent : Klijent
    {
        public string NazivPoduzeca { get; set; }

        public override string ToString()
        {
            return NazivPoduzeca;
        }

        public override string Opis
        {
            get { return $"{NazivPoduzeca}, vl. {Osoba.Ime} {Osoba.Prezime}"; }
        }

        public PoslovniKlijent(string oib, string nazivPoduzeca, string imeVlasnika, string prezimeVlasnika)
            : base(oib, imeVlasnika, prezimeVlasnika)
        {
            Tip = TipKlijenta.Poslovni;
            NazivPoduzeca = nazivPoduzeca;
        }
    }
}
