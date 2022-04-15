using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    public static class Repozitorij
    {
        public static List<Korisnik> Korisnici = new List<Korisnik>();

        public static bool DodajKorisnika(Korisnik korisnik)
        {
            bool postoji = false;
            foreach(Korisnik item in Korisnici)
            {
                if(item.Ime == korisnik.Ime && item.Prezime == korisnik.Prezime)
                {
                    postoji = true;
                }
            }
            return postoji;
            //return Korisnici.Exists(x => x.Ime == korisnik.Ime && x.Prezime == korisnik.Prezime);
        }
    }
}
