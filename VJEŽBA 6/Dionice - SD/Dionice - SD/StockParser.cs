using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StocksLib;

namespace Dionice___SD
{
    public static class StockParser
    {
        public static List<string> listaStringova = StockExchangeAPI.GetStocksData();
        public static List<Stock> Stocks = new List<Stock>();

        public static Stock ParseStock()
        {
            Stock stock = new Stock();
            foreach (string item in listaStringova)
            {
                string[] poljeStringova = item.Split(';');
                stock.Name = poljeStringova[0];
                stock.CurrentPrice = Double.Parse(poljeStringova[1]);
                stock.PreviousPrice = Double.Parse(poljeStringova[2]);
                stock.Difference = Math.Round(((stock.CurrentPrice - stock.PreviousPrice) / stock.PreviousPrice) * 100, 2);
                Stocks.Add(new Stock(stock.Name, stock.CurrentPrice, stock.PreviousPrice, stock.Difference));
            }
            return stock;
        }
    }
}
