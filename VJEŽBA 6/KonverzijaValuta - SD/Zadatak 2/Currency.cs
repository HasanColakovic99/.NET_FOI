using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    public class Currency
    {
        public string Name { get; set; }
        public double ExchangeRate { get; set; }
        public Currency()
        {

        }
        public Currency(string name, double exchangeRate)
        {
            Name = name;
            ExchangeRate = exchangeRate;
        }

        public double ConvertTo(Currency currency2, double amount)
        {
            double rezultat;
            rezultat = amount / currency2.ExchangeRate;
            return rezultat;
        }
    }
}
