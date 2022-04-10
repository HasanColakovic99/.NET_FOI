using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    public class Serija : IVideoZapis
    {
        public List<Sezona> listaSezona = new List<Sezona>();
        public int Trajanje { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public KategorijaZapisa Kategorija { get; set; }
        public Serija(string naziv, string opis)
        {
            this.Naziv = naziv;
            this.Opis = opis;
        }

        public string Reproduciraj()
        {
            return "Započeta reprodukcija serija" + this.Naziv + "Sezone: " + listaSezona[0].RedniBroj + "Epizoda: " + listaSezona[0].listaEpizoda[0].Naziv;
        }


    }
}
