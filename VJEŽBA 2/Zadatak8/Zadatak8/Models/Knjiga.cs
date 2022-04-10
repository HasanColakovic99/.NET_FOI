using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8.Models
{
    public class Knjiga
    {
        public string Naslov;
        public bool Dostupno;
        public string Osoba;


        // POŠTO SU DEFAULT VALUES, NE MORAMO UNOSITI NIŠTA OSIM NASLOVA
        public Knjiga(string naslov)
        {
            this.Naslov = naslov;
            this.Dostupno = true;
            this.Osoba = "";
        }


        public string DohvatiOpis()
        {
            return $"Naslov: {this.Naslov}, Dostupno: {this.Dostupno}, Osoba: {this.Osoba}";
        }
    }
}
