using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Popis_zadataka
{
    public class Stock
    {
        public string Name { get; set; }
        public double CurrentPrice { get; set; }
        public double PreviousPrice { get; set; }
        public double Difference { get; set; }
        public Stock(string name, double currentPrice, double previousPrice)
        {
            Name = name;
            CurrentPrice = currentPrice;
            PreviousPrice = previousPrice;
            Difference = Math.Round((currentPrice - PreviousPrice) / previousPrice * 100, 2, MidpointRounding.ToEven);
        }
        public Stock()
        {

        }
    }
}
