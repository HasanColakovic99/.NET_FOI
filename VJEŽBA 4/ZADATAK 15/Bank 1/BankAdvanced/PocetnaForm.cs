using BankaLib;
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
    public partial class PocetnaForm : Form
    {
        public PocetnaForm()
        {
            InitializeComponent();
        }

        private void novaTransakcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaTransakcijaForm form = new NovaTransakcijaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void popisTransakcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransakcijeForm form = new TransakcijeForm();
            form.MdiParent = this;
            form.Show();
        }

        private void novaTransakcijaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NovaTransakcijaForm form = new NovaTransakcijaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void popisRacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RacuniForm form = new RacuniForm();
            form.MdiParent = this;
            form.Show();
        }

        private void popisKlijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KlijentiForm form = new KlijentiForm();
            form.MdiParent = this;
            form.Show();
        }

        private void kreirajKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreirajKlijentaForm form = new KreirajKlijentaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void tekućiRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtvoriTekuciRacunForm form = new OtvoriTekuciRacunForm();
            form.MdiParent = this;
            form.Show();
        }

        private void devizniRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtvoriDevizniRacunForm form = new OtvoriDevizniRacunForm();
            form.MdiParent = this;
            form.Show();
        }

        private void PocetnaForm_Load(object sender, EventArgs e)
        {
            Repozitorij.UcitajPodatke();
        }
    }
}
