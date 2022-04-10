using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public class Karta
    {
        public Projekcije Projekcija { get; set; }
        public Sjedalo OdabranoSjedalo { get; set; }
        public Karta(Projekcije projekcija, Sjedalo sjedalo)
        {
            this.Projekcija = projekcija;
            this.OdabranoSjedalo = sjedalo;
        }

        public double OdrediCijenu()
        {
            double cijena;
            if(Projekcija.Premijera == true)
            {
                cijena = 60;
            }
            else
            {
                cijena = 40;
            }
            return cijena;
        }
    }
}
