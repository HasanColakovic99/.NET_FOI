using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak20
{
    public class Skladište
    {
        private List<Proizvod> Proizvodi = new List<Proizvod>();

        public bool DodajProizvod (Proizvod proizvod)
        {
            foreach(Proizvod item in this.Proizvodi)
            {
                if (item.Naziv == proizvod.Naziv)
                {
                    return false;
                }
            }
            // DODAT ĆE TAJ PROIZVOD U LISTU PROIZVODA
            this.Proizvodi.Add(proizvod);
            return true;
        }

        public bool UkloniProizvod (Proizvod proizvod)
        {
            foreach (Proizvod item in this.Proizvodi)
            {
                if (item.Naziv == proizvod.Naziv)
                {
                    // UKLANJA PROIZVOD IZ LISTE PROIZVODA
                    this.Proizvodi.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public Proizvod DohvatiProizvod(string naziv)
        {
            foreach(Proizvod item in Proizvodi)
            {
                if(item.Naziv == naziv)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Proizvod> DohvatiSveProizvode()
        {
            // VRAĆA SVE PROIZVODE, TJ. LISTU PROIZVODA
            return this.Proizvodi;
        }

        public int IzracunajUkupnuVrijednostSvihZaliha()
        {
            int sum = 0;
            foreach(Proizvod item in this.Proizvodi)
            {
                sum += item.IzracunajVrijednostZaliha();
            }
            return sum;
        }

    }
}
