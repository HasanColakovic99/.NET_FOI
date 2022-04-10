using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak15.Models
{
    public class Autentifikator
    {
        private List<Korisnik> Korisnici = new List<Korisnik>();

        public Autentifikator()
        {
            Korisnici.Add(new Korisnik("hcolakovi", "123"));
            Korisnici.Add(new Korisnik("fantunovi", "1234"));
            Korisnici.Add(new Korisnik("tfarkas", "12345"));
        }

        private List<Korisnik> DohvatiKorisnika(string korisnickoIme)
        {
            foreach(Korisnik item in Korisnici)
            {
                if (item.KorisnickoIme == korisnickoIme)
                {
                    return Korisnici;
                }
            }
            return null;
        }


        public string PrijaviKorisnika (string korisnickoime, string lozinka)
        {
            string returnMe = "";
            foreach(Korisnik item in Korisnici)
            {
                if (item.KorisnickoIme == korisnickoime && item.Lozinka == lozinka) 
                {
                    return returnMe = "Uspješno ste se prijavili!";
                }
                else if(item.KorisnickoIme == korisnickoime && item.Lozinka != lozinka)
                {
                    return returnMe = "Kriva lozinka!";
                }
                else if(DohvatiKorisnika(korisnickoime) == null)
                {
                    return returnMe = "Ne postoji korisnik sa unešenim korisničkim imenom!";
                }
            }
            return returnMe;
        }

    }
}
