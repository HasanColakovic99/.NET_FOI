using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Models
{
    class Linija
    {
        public string Polaziste;
        public string Odrediste;
        public int Udaljenost;
        public static List<Linija> Linije = new List<Linija>();
        public Linija(string polaziste, string odrediste, int udaljenost)
        {
            this.Polaziste = polaziste;
            this.Odrediste = odrediste;
            this.Udaljenost = udaljenost;
            Linije.Add(this);
        }
    }
}
