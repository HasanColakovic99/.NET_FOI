using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib2;

namespace Zadatak3
{
    public partial class Form1 : Form
    {
        AutobusniKolodvor kolodvor = new AutobusniKolodvor();
        public Form1()
        {
            InitializeComponent();
        }


        private void AutobusneLinije()
        {
            List<Linija> linije = kolodvor.DohvatiLinije();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = linije;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutobusneLinije();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutobusniKolodvor kolodvor = new AutobusniKolodvor();
            List<Linija> linije = kolodvor.DohvatiLinije(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = linije;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Linija linija = dataGridView1.CurrentRow.DataBoundItem as Linija;
            Kupi_kartu karta = new Kupi_kartu(linija);
            this.Hide();
            karta.ShowDialog();
        }
    }
}
