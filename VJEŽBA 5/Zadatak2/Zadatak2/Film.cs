using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    public class Film : IVideoZapis
    {
        public int Trajanje { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public KategorijaZapisa Kategorija { get; set; }
        public Film(string naziv, string opis, int trajanje)
        {
            this.Naziv = naziv;
            this.Opis = opis;
            this.Trajanje = trajanje;
        }

        public string Reproduciraj()
        {
            return "Započeta reprodukcija filma" + this.Naziv;
        }
    }
}
