using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7.Models
{
    public class Knjižnica
    {
        private List<Knjiga> popisKnjiga = new List<Knjiga>();

        public Knjižnica()
        {
            popisKnjiga.Add(new Knjiga("1", "Rat i mir", Knjiga.StatusKnjiga.NaPosudbi));
            popisKnjiga.Add(new Knjiga("2", "Ana Karenjina", Knjiga.StatusKnjiga.Dostupno));
            popisKnjiga.Add(new Knjiga("3", "Zeleno Busenje", Knjiga.StatusKnjiga.Dostupno));
        }
    }
}
