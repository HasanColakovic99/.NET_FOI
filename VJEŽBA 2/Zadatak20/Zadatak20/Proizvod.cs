using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak20
{
    public class Proizvod
    {
        public string Naziv;
        public int JedinicnaCijena;
        public int Stanje;

        public Proizvod(string naziv, int jedinicnacijena, int stanje)
        {
            this.Naziv = naziv;
            this.JedinicnaCijena = jedinicnacijena;
            this.Stanje = stanje;
        }


        public string Ispis()
        {
            return "Naziv proizvoda: " + this.Naziv + " Cijena proizvoda: " + this.JedinicnaCijena + " Stanje u skladištu: " + this.Stanje; 
        }

        public int IzracunajVrijednostZaliha()
        {
            return this.Stanje * this.JedinicnaCijena;
        }

        public bool DodajNaStanje(int kolicina)
        {
            if(kolicina > 0) 
            {
                this.Stanje += kolicina;
                return true;
            }
            return false;
        } 


        public bool OduzmiSaStanja (int kolicina)
        {
            if (kolicina > 0 && this.Stanje >= kolicina)
            {
                this.Stanje -= kolicina;
                return true;
            }
            return false;
        }



    }
}
