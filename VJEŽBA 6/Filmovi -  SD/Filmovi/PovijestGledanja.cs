using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class PovijestGledanja
    {
        public List<PogledaniFilm> historijaFilmova = new List<PogledaniFilm>();

        public PovijestGledanja()
        {
            historijaFilmova.Add(new PogledaniFilm(1, 90));
            historijaFilmova.Add(new PogledaniFilm(2, 70));
            historijaFilmova.Add(new PogledaniFilm(5, 55));
        }

        public List<PogledaniFilm> DohvatiPogledaneFilmove()
        {
            return historijaFilmova;
        }
    }
}
