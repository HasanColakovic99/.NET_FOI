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
    public partial class OdaberiRacunForm : Form
    {
        public IRacun OdabraniRacun { get; set; }
        private IKlijent _klijent;

        public OdaberiRacunForm(IKlijent klijent)
        {
            InitializeComponent();
            _klijent = klijent;
        }

        private void OdaberiRacunForm_Load(object sender, EventArgs e)
        {
            racunDataGridView.DataSource = Repozitorij.DohvatiRacune(_klijent).ToList();
        }

        private void odaberiButton_Click(object sender, EventArgs e)
        {
            OdabraniRacun = DohvatiSelektiranogRacuna();
            Close();
        }

        private IRacun DohvatiSelektiranogRacuna()
        {
            if (racunDataGridView.CurrentRow != null)
            {
                return racunDataGridView.CurrentRow.DataBoundItem as IRacun;
            }
            return null;
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            OdabraniRacun = null;
            Close();
        }
    }
}
