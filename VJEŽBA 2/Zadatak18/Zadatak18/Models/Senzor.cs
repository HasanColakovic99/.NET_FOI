using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak18.Models
{
    public class Senzor
    {
        public string Oznaka;
        public double Vrijednost;
        public enum JedinicaMjera { Celzijus, Kelvin}
        public JedinicaMjera JedinicaMjere;

        public Senzor(string oznaka, double vrijednost, JedinicaMjera jedinicamjere)
        {
            this.Oznaka = oznaka;
            this.Vrijednost = vrijednost;
            this.JedinicaMjere = jedinicamjere;
        }
    }
}
