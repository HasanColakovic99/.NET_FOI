using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class KonverterValuta
    {
        public TecajnaLista TecajnaLista { get; set; } = new TecajnaLista();

        public double Konvertiraj(Valuta izvorisna, Valuta odredisna, double iznos)
        {
            double tecajIzvorisna = TecajnaLista.DohvatiTecaj(izvorisna).Vrijednost;
            double tecajOdredisna = TecajnaLista.DohvatiTecaj(odredisna).Vrijednost;

            return (tecajIzvorisna / tecajOdredisna) * iznos;
        }
    }
}
