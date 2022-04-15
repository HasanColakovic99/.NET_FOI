using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class KatalogFilmova
    {
        public List<Film> listaFilmova = new List<Film>();

        public KatalogFilmova()
        {
            listaFilmova.Add(new Film(1, "Batman", 90));
            listaFilmova.Add(new Film(2, "Superman", 85));
            listaFilmova.Add(new Film(3, "Spiderman", 98));
            listaFilmova.Add(new Film(4, "Ironman", 110));
            listaFilmova.Add(new Film(5, "Hulk", 115));
        }

        public List<Film> DohvatiSveFilmove()
        {
            return listaFilmova;
        }
    }
}
