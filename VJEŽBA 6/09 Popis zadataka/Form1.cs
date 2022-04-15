using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Popis_zadataka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            StockManager sm = new StockManager();
            List<Stock> stocks = sm.GetStocks();
            ShowData(stocks);
        }

        private void ShowData(List<Stock> stocks)
        {
            dataGridViewStocks.DataSource = null;
            dataGridViewStocks.DataSource = stocks;
        }
    }
}
