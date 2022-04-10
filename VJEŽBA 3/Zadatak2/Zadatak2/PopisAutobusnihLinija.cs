using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace Zadatak2
{
    public partial class PopisAutobusnihLinija : Form
    {
        public PopisAutobusnihLinija()
        {
            InitializeComponent();
        }

        private void PopisAutobusnihLinija_Load(object sender, EventArgs e)
        {
            PopisLinija();
        }

        private void PopisLinija()
        {
            List<Linija> Linije = AutobusniKolodvor.DohvatiLinije();
            autobusneLinijeDataGridView.DataSource = null;
            autobusneLinijeDataGridView.DataSource = Linije;
        }

        private void odaberiButton_Click(object sender, EventArgs e)
        {
            Linija currentLinija = autobusneLinijeDataGridView.CurrentRow.DataBoundItem as Linija;
            Kreiranje_karte karta = new Kreiranje_karte(currentLinija);
            this.Hide();
            karta.ShowDialog();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
