using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak12.Models
{
    public class KorisničkiRačun
    {
        public string Ime;
        public string Prezime;
        public string Email;
        public string SkraceniEmail;
        public string Lozinka;
        public static List<KorisničkiRačun> KorisnickiRacuni = new List<KorisničkiRačun>();
        public KorisničkiRačun(string ime, string prezime, string email, string skraceniEmail, string lozinka)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.SkraceniEmail = skraceniEmail;
            this.Lozinka = lozinka;
            KorisnickiRacuni.Add(this);
        }
    }
}
