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


namespace AutobusniKolodovor
{
    public partial class PopisLinijaForm : Form
    {
        public Linija OdabranaLinja { get; set; }
        public PopisLinijaForm()
        {
            InitializeComponent();
        }

        private void PopisLinijaForm_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }


        private void OsvjeziPopis()
        {
            List<Linija> popisLinija = AutobusniKolodvor.DohvatiLinije();
            linijeDataGridView.DataSource = null;
            linijeDataGridView.DataSource = popisLinija;
        }

        private void odaberiButton_Click(object sender, EventArgs e)
        {
            this.OdabranaLinja = linijeDataGridView.CurrentRow.DataBoundItem as Linija;
            Close();
        }

        public void izlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
