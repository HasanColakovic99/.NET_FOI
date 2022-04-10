using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2.Models
{
    public class Banka
    {
        private List<Račun> Racuni = new List<Račun>();

        public Banka()
        {
            Racuni = new List<Račun>();
            Racuni.Add(new Račun("HR11", 100000));
            Racuni.Add(new Račun("HR22", 50000));
            Racuni.Add(new Račun("HR33", 12000));
            Racuni.Add(new Račun("HR44", 36000));
        }


        // SA UNESENIM IBANOM PROVJERAVAMO DA LI TAKAV RAČUN POSTOJI
        // AKO POSTOJI, VRATI MI RAČUN I NJEGOV TRENUTNI IZNOS
        private Račun DohvatiRacun (string iban)
        {
            foreach(Račun item in Racuni)
            {
                if(item.IBAN == iban)
                {
                    return item;
                }
            }
            return null;
        }


        public Transakcija IzvrsiPlacanje (string ibanPlatitelja, string ibanPrimatelja, double iznos)
        {
            foreach(Račun item in Racuni)
            {
                if (item.IBAN == ibanPlatitelja)
                {
                    item.Stanje -= iznos;
                }
                if(item.IBAN == ibanPrimatelja)
                {
                    item.Stanje += iznos;
                }
            }
            return new Transakcija(DohvatiRacun(ibanPlatitelja), DohvatiRacun(ibanPrimatelja), iznos);
        }

    }
}
