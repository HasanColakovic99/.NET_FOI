using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_2
{
    public partial class Form1 : Form
    {
        CurrencyFactory currencyFactory = new CurrencyFactory();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowResult();
        }

        public void ShowResult()
        {
            Currency currency = new Currency();
            var odredisnaValuta = currencyFactory.GetCurrency2(comboBox2.SelectedItem.ToString());
            double zeljeniIznos = double.Parse(textBox1.Text);

            var pretvoreniIznos = currency.ConvertTo(odredisnaValuta, zeljeniIznos);
            textBox2.Text = pretvoreniIznos.ToString();
        }
    }
}
