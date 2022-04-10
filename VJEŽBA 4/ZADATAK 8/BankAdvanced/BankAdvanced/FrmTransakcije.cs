using BankaLib;
using KorisniciLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAdvanced
{
    public partial class FrmTransakcije : Form
    {
        private IRacun racun;
        public IRacun Racun { get => racun; set => racun = value; }

        public FrmTransakcije()
        {
            InitializeComponent();
        }

        public FrmTransakcije(IRacun odabraniRacun)
        {
            InitializeComponent();
            Racun = odabraniRacun;
        }

        private void FrmTransakcije_Load(object sender, EventArgs e)
        {
            if (Racun != null)
            {
                PrikaziTransakcijeRacuna();
                btnNovaTransakcija.Visible = false;
                cmbKriterij.Visible = false;
                txtIznos.Visible = false;
                btnFiltriraj.Visible = false;
                label1.Visible = false;
                btnOcisti.Visible = false;
            }
            else
            {
                PrikaziSveTransakcije();
                btnNovaTransakcija.Visible = true;
                cmbKriterij.Visible = true;
                txtIznos.Visible = true;
                btnFiltriraj.Visible = true;
                label1.Visible = true;
                btnOcisti.Visible = true;
            }
        }

        private void PrikaziSveTransakcije()
        {
            var sveTransakcije = KorisniciDB.VratiSveTransakcije();
            transakcijeDataGridView.DataSource = sveTransakcije;
        }

        private void PrikaziTransakcijeRacuna()
        {
            List<Transakcija> transakcijeRacuna = Racun.VratiSveTransakcije().ToList();
            transakcijeDataGridView.DataSource = transakcijeRacuna;
        }

        private void zatvoriButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovaTransakcija_Click(object sender, EventArgs e)
        {
            var form = new FrmNovaTransakcija();
            form.ShowDialog();
            PrikaziSveTransakcije();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            double iznosZaUsporedbu = double.Parse(txtIznos.Text);
            List<Transakcija> transakcije;
            if (cmbKriterij.SelectedIndex == 0)
            {
                transakcije = KorisniciDB.VratiSveTransakcije().FindAll(t => t.Iznos < iznosZaUsporedbu);
            }
            else
            {
                transakcije = KorisniciDB.VratiSveTransakcije().FindAll(t => t.Iznos > iznosZaUsporedbu);
            }

            transakcijeDataGridView.DataSource = transakcije.ToList();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtIznos.Text = "";
            cmbKriterij.SelectedIndex = 0;
            transakcijeDataGridView.DataSource = KorisniciDB.VratiSveTransakcije().ToList();
        }
    }
}
