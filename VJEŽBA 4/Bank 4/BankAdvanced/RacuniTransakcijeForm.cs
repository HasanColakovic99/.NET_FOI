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
    public partial class RacuniTransakcijeForm : Form
    {
        private IRacun racun;
        public RacuniTransakcijeForm(IRacun odabraniRacun)
        {
            InitializeComponent();
            racun = odabraniRacun;
        }

        private void RacuniTransakcijeForm_Load(object sender, EventArgs e)
        {
            transakcijeDataGridView.DataSource = racun.DohvatiTransakcije().ToList();
        }

        private void zatvoriButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
