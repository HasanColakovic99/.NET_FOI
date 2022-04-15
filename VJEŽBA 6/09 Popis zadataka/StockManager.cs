using StocksLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Popis_zadataka
{
    public class StockManager
    {
        List<string> stocksData = StockExchangeAPI.GetStocksData();
        List<Stock> stocks = new List<Stock>();
        public List<Stock> GetStocks()
        {
            foreach (string item in stocksData)
            {
                stocks.Add(StockParser.ParseStock(item));
            }
            return stocks;
        }
    }
}
