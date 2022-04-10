using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib
{
    public class Mjenjacnica
    {
        public static double PromijeniNovac(string izvorisna, string odredisna, double iznos)
        {
            var izvorisnaValuta = MjenjacnicaDB.VratiValutuPoNazivu(izvorisna);
            var odredisnaValuta = MjenjacnicaDB.VratiValutuPoNazivu(odredisna);

            var tecajIzvorisneValute = MjenjacnicaDB.PopisTecajeva.VratiTecajZaValutu(izvorisnaValuta);
            var tecajOdredisneValute = MjenjacnicaDB.PopisTecajeva.VratiTecajZaValutu(odredisnaValuta);

            var omjerTecaja = tecajIzvorisneValute.Vrijednost / tecajOdredisneValute.Vrijednost;

            return omjerTecaja * iznos;
        }

        public double PromijeniNovac(Valuta izvorisna, Valuta odredisna, double iznos)
        {
            var tecajIzvorisneValute = MjenjacnicaDB.PopisTecajeva.VratiTecajZaValutu(izvorisna);
            var tecajOdredisneValute = MjenjacnicaDB.PopisTecajeva.VratiTecajZaValutu(odredisna);

            var omjerTecaja = tecajIzvorisneValute.Vrijednost / tecajOdredisneValute.Vrijednost;

            return omjerTecaja * iznos;
        }
    }
}
