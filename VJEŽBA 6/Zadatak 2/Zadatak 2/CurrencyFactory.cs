using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    public class CurrencyFactory
    {
        public List<Currency> Tecajevi = new List<Currency>();
        public CurrencyFactory()
        {
            Tecajevi.Add(new Currency("HRK", 1));
            Tecajevi.Add(new Currency("EUR", 7.4));
            Tecajevi.Add(new Currency("USD", 6.5));
            Tecajevi.Add(new Currency("GBP", 8.5));
            Tecajevi.Add(new Currency("CAD", 4.9));
        }

        public Currency GetCurrency (string currName1)
        {
            foreach(Currency item in Tecajevi)
            {
                if(item.Name == currName1)
                {
                    return item;
                }
            }
            return null;
        }

        public Currency GetCurrency2(string currName2)
        {
            foreach (Currency item in Tecajevi)
            {
                if (item.Name == currName2)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
