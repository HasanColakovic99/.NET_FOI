using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public class Blagajna
    {
        public List<Karta> prodaneKarte = new List<Karta>();

        public Karta ProdajKartu(Projekcije projekcija, Sjedalo sjedalo)
        {
            bool ima = false;
            foreach(Karta item in prodaneKarte)
            {
                if (!(item.OdabranoSjedalo.OznakaSjedala == sjedalo.OznakaSjedala && item.Projekcija.Datum == projekcija.Datum))
                {
                    ima = true;
                }
            }
            if (!ima)
            {
                Karta karta = new Karta(projekcija, sjedalo);
                prodaneKarte.Add(karta);
                return karta;
            }
            return null;
        }
    }
}
