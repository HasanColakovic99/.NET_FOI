using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_PI_Projekt
{
    public partial class FrmProjekt : Form
    {
        private Projekt _projekt;
        public FrmProjekt()
        {
            InitializeComponent();
        }

        public void Osvjezi()
        {
            StanjeProjekta2.Stanje stanje = _projekt.Stanje.TrenutnoStanje;
            btnZabiljeziTemu.Enabled = stanje == StanjeProjekta2.Stanje.NijePrijavljenaTema;
            btnPredajProjekt.Enabled = stanje == StanjeProjekta2.Stanje.TemaPrijavljena;
            btnPrihvatiProjekt.Enabled = stanje == StanjeProjekta2.Stanje.PredanProjekt;
            btnOdbijProjekt.Enabled = stanje == StanjeProjekta2.Stanje.PredanProjekt;
            btnZakaziObranu.Enabled = stanje == StanjeProjekta2.Stanje.PrihvacenProjekt;
            btnOznaciKaoObranjen.Enabled = stanje == StanjeProjekta2.Stanje.ZakazanaObrana;
        }

        private void FrmProjekt_Load(object sender, EventArgs e)
        {
            _projekt = new Projekt();
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnZabiljeziTemu_Click(object sender, EventArgs e)
        {
            StanjeProjekta2.Stanje stanje = _projekt.Stanje.TrenutnoStanje;
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            if(stanje == StanjeProjekta2.Stanje.NijePrijavljenaTema)
            {
                _projekt.ZabiljeziTemu(txtOpisProjekta.Text, txtOznakaTima.Text);
            }
            else
            {
                MessageBox.Show("Ne može ta tema");
            }
            Osvjezi();
        }

        private void btnPredajProjekt_Click(object sender, EventArgs e)
        {
            _projekt.PredajProjekt(dtpDatumPredaje.Value);
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnOdbijProjekt_Click(object sender, EventArgs e)
        {
            _projekt.OdbijProjekt();
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnPrihvatiProjekt_Click(object sender, EventArgs e)
        {
            _projekt.PrihvatiProjekt();
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnZakaziObranu_Click(object sender, EventArgs e)
        {
            _projekt.ZakažiObranu(dtpDatumObrane.Value);
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnOznaciKaoObranjen_Click(object sender, EventArgs e)
        {
            _projekt.OznačiKaoObranjen();
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }
    }
}
