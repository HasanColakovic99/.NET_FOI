using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak15.Models
{
    public class Korisnik
    {
        public string KorisnickoIme;
        public string Lozinka;

        public Korisnik(string korisnickoIme, string lozinka)
        {
            this.KorisnickoIme = korisnickoIme;
            this.Lozinka = lozinka;
        }
    }
}
