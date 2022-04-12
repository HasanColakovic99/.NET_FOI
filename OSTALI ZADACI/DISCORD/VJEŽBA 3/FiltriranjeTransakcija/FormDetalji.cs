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

namespace FiltriranjeTransakcija
{
    public partial class FormDetalji : Form
    {
        public Racun BankovniRacun { get; set; }

        public FormDetalji(Racun racun)
        {
            InitializeComponent();
            BankovniRacun = racun;
        }

        private void FormDetalji_Load(object sender, EventArgs e)
        {
            textBoxIBAN.Text = BankovniRacun.IBAN;
            textBoxVlasnik.Text = BankovniRacun.Vlasnik;
            textBoxStanje.Text = BankovniRacun.Stanje.ToString();
            textBoxPromet.Text = BankovniRacun.IzracunajUkupanPromet().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
