using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak14.Models
{
    public class StreamingServis
    {
        public List<Film> Filmovi = new List<Film>();

        public StreamingServis()
        {
            Filmovi.Add(new Film("Film 1", Film.Žanr.Komedija, 88, false));
            Filmovi.Add(new Film("Film 2", Film.Žanr.Akcija, 95, false));
            Filmovi.Add(new Film("Film 3", Film.Žanr.Horor, 70, true));
            Filmovi.Add(new Film("Film 4", Film.Žanr.Komedija, 120, false));
            Filmovi.Add(new Film("Film 5", Film.Žanr.Akcija, 110, true));
            Filmovi.Add(new Film("Film 6", Film.Žanr.Horor, 99, false));
            Filmovi.Add(new Film("Film 7", Film.Žanr.Komedija, 75, false));
            Filmovi.Add(new Film("Film 8", Film.Žanr.Akcija, 85, true));
            Filmovi.Add(new Film("Film 9", Film.Žanr.Horor, 81, true));
            Filmovi.Add(new Film("Film 10", Film.Žanr.Komedija, 99, true));
        }

        private List<Film> DohvatiFilmoveKojeNisamGledao()
        {
            foreach(Film item in Filmovi)
            {
                if(item.VecGledan == false)
                {
                    
                }
            }
            return null;
        }

        

    }
}
