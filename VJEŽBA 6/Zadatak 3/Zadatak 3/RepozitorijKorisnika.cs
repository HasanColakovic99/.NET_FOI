using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    public class RepozitorijKorisnika
    {
        public List<Korisnik> Korisnici = new List<Korisnik>();
        public RepozitorijKorisnika()
        {
            Korisnici.Add(new Korisnik(1, "pperic"));
            Korisnici.Add(new Korisnik(2, "ihorvat"));
        }

        public Korisnik DohvatiKorisnika(string korIme)
        {
            foreach(Korisnik item in Korisnici)
            {
                if(item.KorisnickoIme == korIme)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
