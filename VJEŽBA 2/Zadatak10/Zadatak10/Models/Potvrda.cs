using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10.Models
{
    public class Potvrda
    {
        public DateTime Datum;
        public double Kune;
        public double Tečaj;
        public double Naknada;
        public double Bruto;
        public double Isplata;

        public Potvrda(double kune, double tecaj, double naknada, double bruto, double isplata)
        {
            this.Kune = kune;
            this.Tečaj = tecaj;
            this.Naknada = naknada;
            this.Bruto = bruto;
            this.Isplata = isplata;
            this.Datum = DateTime.Now;
        }
    }
}
