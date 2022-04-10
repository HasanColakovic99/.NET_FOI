using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace Zadatak9
{
    public partial class Provedi_transakciju : Form
    {
        public Provedi_transakciju()
        {
            InitializeComponent();
        }

        private void Provedi_transakciju_Load(object sender, EventArgs e)
        {
            List<Racun> listaRacuna = Banka.DohvatiPopisRacuna().ToList<Racun>();
            comboBox1.DataSource = listaRacuna;
            comboBox2.DataSource = Banka.DohvatiPopisRacuna().ToList<Racun>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banka.ProvediTransakciju(comboBox1.SelectedItem as Racun, comboBox2.SelectedItem as Racun, double.Parse(textBox1.Text));
            Close();
        }
    }
}
