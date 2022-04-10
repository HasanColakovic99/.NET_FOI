using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak14.Models
{
    public class Film
    {
        public string Naziv;
        public enum Žanr { Komedija, Akcija, Horor}
        public Žanr Zanr;
        public int Trajanje;
        public bool VecGledan;

        public Film(string naziv, Žanr zanr, int trajanje, bool vecGledan)
        {
            this.Naziv = naziv;
            this.Zanr = zanr;
            this.Trajanje = trajanje;
            this.VecGledan = vecGledan;
        }

        public string DohvatiInfo()
        {
            return $"{this.Naziv} ({this.Zanr}, {this.Trajanje})";
        }

    }
}
