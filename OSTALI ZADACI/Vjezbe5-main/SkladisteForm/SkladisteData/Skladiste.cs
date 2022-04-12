using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteData
{
    public class Skladiste
    {
        public List<IArtikli> Artikli = new List<IArtikli>();

        public Skladiste()
        {
            Artikli.Add(new DomaciProizvodi("Domaci proizvod 1", 1, 1));
        }

        public List<IArtikli> DohvatiArtikle()
        {
            return Artikli;
        }

        public void DodajDomaciProizvod(string naziv, int cijena, int kolicina)
        {
            Artikli.Add(new DomaciProizvodi(naziv, cijena, kolicina));
        }

        public void DodajUvezeniProizvod(string naziv, int cijena, int kolicina)
        {
            Artikli.Add(new UvezeniProizvodi(naziv, cijena, kolicina));
        }
    }
}
