using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomoviData
{
    public class Klub
    {
        public string Naziv { get; set; }
        public List<Tim> Timovi { get; set; }
        public List<Nogometas> Nogometasi { get; set; }
        public int ID { get; set; }

        public Klub()
        {
            Random random = new Random();
            this.ID = random.Next();
            Timovi = new List<Tim>();
            Nogometasi = new List<Nogometas>();
            Nogometasi.Add(new Nogometas("Hasan", "Colakovic", this.ID, PozicijaIgraca.Pozicija.Napadač));
            Timovi.Add(new Tim(this.ID, VrstaTaktike.Taktika._4_4_2, "Real Madrid", 1));
        }


        public void DodajNogometasa(string ime, string prezime, PozicijaIgraca.Pozicija pozicija)
        {
            Nogometasi.Add(new Nogometas(ime, prezime, this.ID, pozicija));
        }

        public List<Tim> DohvatiTimove()
        {
            return this.Timovi;
        }

        public List<Nogometas> DohvatiNogometaseTima(Tim tim)
        {
            return tim.NogometasiTima;
        }

        public List<Nogometas> DostupniNogometasi()
        {
            return Nogometasi.FindAll(x => x.ID_Tima == 0);
        }
    }
}
