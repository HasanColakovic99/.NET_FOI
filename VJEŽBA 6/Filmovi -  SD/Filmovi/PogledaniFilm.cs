using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class PogledaniFilm
    {
        public int IdFilma { get; set; }
        public int TrenutnaMinuta { get; set; }

        public PogledaniFilm(int idFilma, int trenutnaMinuta)
        {
            IdFilma = idFilma;
            TrenutnaMinuta = trenutnaMinuta;
        }
    }
}
