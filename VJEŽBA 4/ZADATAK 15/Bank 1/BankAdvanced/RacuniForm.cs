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
    public partial class RacuniForm : Form
    {
        public RacuniForm()
        {
            InitializeComponent();
        }

        private void detaljiButton_Click(object sender, EventArgs e)
        {
            IRacun racun = DohvatiSelektiraniRacun();
            RacuniTransakcijeForm form = new RacuniTransakcijeForm(racun);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private IRacun DohvatiSelektiraniRacun()
        {
            if (racuniDataGridView.CurrentRow != null)
            {
                return racuniDataGridView.CurrentRow.DataBoundItem as IRacun;
            }
            return null;
        }

        private void RacuniForm_Load(object sender, EventArgs e)
        {
            racuniDataGridView.DataSource = Repozitorij.DohvatiRacune().ToList();
        }
    }
}
