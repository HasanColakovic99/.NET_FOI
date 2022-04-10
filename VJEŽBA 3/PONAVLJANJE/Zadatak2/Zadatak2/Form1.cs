using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace Zadatak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void AutobusneLinije()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AutobusniKolodvor.DohvatiLinije();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutobusneLinije();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Linija linija = dataGridView1.CurrentRow.DataBoundItem as Linija;
            Kreiranje_karte karta = new Kreiranje_karte(linija);
            this.Hide();
            karta.ShowDialog();
        }
    }
}
