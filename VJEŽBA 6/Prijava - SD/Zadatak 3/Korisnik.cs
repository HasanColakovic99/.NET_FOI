using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    public class Korisnik
    {
        public int ID { get; set; }
        public string KorisnickoIme { get; set; }

        public Korisnik(int id, string korisnickoIme)
        {
            ID = id;
            KorisnickoIme = korisnickoIme;
        }
    }
}
