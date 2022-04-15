using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public Korisnik(string ime, string prezime)
        {
            Generator generator = new Generator();
            Ime = ime;
            Prezime = prezime;
            Email = generator.GenerirajEmail(ime, prezime);
            Lozinka = generator.GenerirajLozinku();
        }
    }
}
