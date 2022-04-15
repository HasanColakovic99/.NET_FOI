using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    public class Repozitorij
    {
        public List<Korisnik> Korisnici = new List<Korisnik>();
        public List<Vrata> Vrata = new List<Vrata>();

        public Repozitorij()
        {
            Korisnici.Add(new Korisnik(10001, 1234, 1));
            Korisnici.Add(new Korisnik(10002, 0000, 2));
            Korisnici.Add(new Korisnik(10003, 9999, 2));

            Vrata.Add(new Vrata(501, 1));
            Vrata.Add(new Vrata(502, 2));
            Vrata.Add(new Vrata(503, 2));
        }
        public Korisnik DohvatiKorisnika(int brKartice, int pin)
        {
            foreach(Korisnik item in Korisnici)
            {
                if(item.BrojKartice == brKartice && item.PIN == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public Vrata DohvatiVrata(int brVrata)
        {
            foreach(Vrata item in Vrata)
            {
                if(item.BrojVrata == brVrata)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
