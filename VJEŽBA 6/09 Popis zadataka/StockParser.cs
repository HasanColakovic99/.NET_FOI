using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Popis_zadataka
{
    public static class StockParser
    {
        public static Stock ParseStock(string item)
        {
            string[] stockString = item.Split(';');
            Stock stock = new Stock(stockString[0], double.Parse(stockString[1]), double.Parse(stockString[2]));
            return stock;
        }
    }
}
