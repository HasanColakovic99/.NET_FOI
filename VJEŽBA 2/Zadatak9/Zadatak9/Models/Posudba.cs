using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak9.Models
{
    public class Posudba
    {
        public string Osoba;
        public Knjiga PosudjenaKnjiga;
        public DateTime Datum;

        public Posudba(string osoba, Knjiga posudjenaKnjiga)
        {
            this.Osoba = osoba;
            this.PosudjenaKnjiga = posudjenaKnjiga;
            this.Datum = DateTime.Now;
        }
    }
}
