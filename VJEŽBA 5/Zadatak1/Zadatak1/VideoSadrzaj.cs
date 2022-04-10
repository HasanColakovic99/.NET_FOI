using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public enum VrstaSadrzaja
    {
        Film, Serija
    }
    public abstract class VideoSadrzaj
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public VrstaSadrzaja vrsta { get; set; }

        public VideoSadrzaj(string naziv, string opis)
        {
            Naziv = naziv;
            Opis = opis;
        }
        public abstract string VratiInfo();
    }
}
