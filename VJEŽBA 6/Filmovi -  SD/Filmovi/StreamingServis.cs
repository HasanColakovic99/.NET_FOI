using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class StreamingServis
    {
        public List<Film> zapocetiFilmovi = new List<Film>();
        PovijestGledanja povijest = new PovijestGledanja();
        KatalogFilmova filmovi = new KatalogFilmova();
        public List<Film> DohvatiZapoceteFilmove()
        {
            foreach(Film film in filmovi.listaFilmova)
            {
                foreach(PogledaniFilm pogledaniFilm in povijest.historijaFilmova)
                {
                    if(film.ID == pogledaniFilm.IdFilma && film.Trajanje > pogledaniFilm.TrenutnaMinuta)
                    {
                        zapocetiFilmovi.Add(film);
                    }
                }
            }
            return zapocetiFilmovi;
        }
    }
}
