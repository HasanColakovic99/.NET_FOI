using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomoviData
{
    public class Nogometas : IOsoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int ID_Kluba { get; set; }
        public int ID_Tima { get; set; }
        public PozicijaIgraca.Pozicija PozicijaIgraca { get; set; }

        public Nogometas(string ime, string prezime, int id, PozicijaIgraca.Pozicija pozicija)
        {
            Ime = ime;
            Prezime = ime;
            ID_Kluba = id;
            PozicijaIgraca = pozicija;
            ID_Tima = 0;
        }
    }
}
