using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public class Film : VideoSadrzaj
    {
        public int Trajanje { get; set; }
        public Film(string naziv, string opis, int trajanje) : base (naziv, opis)
        {
            Trajanje = trajanje;
        }

        public override string VratiInfo() {
            return "Naziv: " + this.Naziv + "Opis: " + this.Opis + "Trajanje: " + this.Trajanje.ToString();
        }
    }
}
