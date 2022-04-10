using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak13.Models
{
    public class Brojilo
    {
        public string Naziv;
        public enum TipBrojila { Voda, Struja, Plin}
        public TipBrojila Tip;
        private double Stanje;
        private double ZadnjeOcitanje;

        public Brojilo(string naziv, TipBrojila tip, double stanje, double zadnjeOcitanje)
        {
            this.Naziv = naziv;
            this.Tip = tip;
            this.Stanje = stanje;
            this.ZadnjeOcitanje = zadnjeOcitanje;
        }


        public double OcitajPotrosnju()
        {
            double rezultat = 0;
            rezultat = this.Stanje - this.ZadnjeOcitanje;
            return rezultat;
        }

    }
}
