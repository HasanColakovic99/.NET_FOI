using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2.Models
{
    public class Račun
    {
        public string IBAN;
        public double Stanje;

        public Račun(string iban, double stanje)
        {
            this.IBAN = iban;
            this.Stanje = stanje;
        }
    }
}
