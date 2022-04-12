using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteData
{
    public class DomaciProizvodi : IArtikli
    {
        public string Naziv { get; set; }
        public int Cijena { get; set; }
        public int Kolicina { get; set; }


        public DomaciProizvodi(string naziv, int cijena, int kolicina)
        {
            if (kolicina < 0)
            {
                throw new NotImplementedException("Ne možete unijeti negativnu količinu!");
            }
            Naziv = naziv;
            Cijena = cijena;
            Kolicina = kolicina;
        }

        public void DodajKolicinu()
        {
            this.Kolicina++;
        }

        public void OduzmiKolicinu()
        {
            if(this.Kolicina > 0)
            {
                this.Kolicina--;
            }
        }
    }
}
