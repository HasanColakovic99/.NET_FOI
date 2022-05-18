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

        private void FrmProjekt_Load(object sender, EventArgs e)
        {
            _projekt = new Projekt();
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        public void Osvjezi()
        {
            StanjeProjekta.Stanje stanje = _projekt.Stanje.TrenutnoStanje;
            btnZabiljeziTemu.Enabled = stanje == StanjeProjekta.Stanje.TemaNijePrijavljena;
            btnOdbijTemu.Enabled = stanje == StanjeProjekta.Stanje.TemaPrijavljena;
            btnPrihvatiTemu.Enabled = stanje == StanjeProjekta.Stanje.TemaPrijavljena;
            btnPredajPrvuFazu.Enabled = stanje == StanjeProjekta.Stanje.TemaPrihvacena;
            btnPredajCijeliProjekt.Enabled = stanje == StanjeProjekta.Stanje.PredanaPrvaFaza;
            btnOcijeniProjekt.Enabled = stanje == StanjeProjekta.Stanje.PredanProjekt;
        }

        private void btnZabiljeziTemu_Click(object sender, EventArgs e)
        {
            _projekt.ZabiljeziTemu(txtOpisTeme.Text, txtOznakaTima.Text);
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnPredajPrvuFazu_Click(object sender, EventArgs e)
        {
            _projekt.PredajPrvuFazu(dtpDatumPrveFaze.Value);
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnOdbijTemu_Click(object sender, EventArgs e)
        {
            _projekt.OdbijTemu();
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnPrihvatiTemu_Click(object sender, EventArgs e)
        {
            _projekt.PrihvatiTemu();
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnPredajCijeliProjekt_Click(object sender, EventArgs e)
        {
            _projekt.PredajCijeliProjekt(dtpDatumPredajeCijelogProjekta.Value);
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnOcijeni_Click(object sender, EventArgs e)
        {
            _projekt.OcijeniProjekt(int.Parse(txtBrojBodova.Text));
            txtStatus.Text = _projekt.Stanje.TrenutnoStanje.ToString();
            Osvjezi();
        }
    }
}
