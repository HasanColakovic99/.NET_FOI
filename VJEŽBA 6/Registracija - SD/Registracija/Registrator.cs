using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    public class Registrator
    {
        public bool Registriraj(string ime, string prezime)
        {
            Korisnik korisnik = new Korisnik(ime, prezime);
            bool postoji = false;
            if(!Repozitorij.DodajKorisnika(korisnik))
            {
                postoji = true;
                Repozitorij.Korisnici.Add(korisnik);
                return postoji;
            }
            return postoji;
        }
    }
}
