using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib2;

namespace AutobusniKolodvor2
{
    public partial class FormAutobusneLinije : Form
    {
        private AutobusniKolodvor AutobusniKolodvor { get; set; }
        public FormAutobusneLinije()
        {
            AutobusniKolodvor = new AutobusniKolodvor();
            InitializeComponent();
        }

        private void FormAutobusneLinije_Load(object sender, EventArgs e)
        {
            OsvjeziLinije();
        }

        private void OsvjeziLinije()
        {
            List<Linija> popisLinija = AutobusniKolodvor.DohvatiLinije();
            dataGridViewLinije.DataSource = null;
            dataGridViewLinije.DataSource = popisLinija;
        }

        private void buttonPronadji_Click(object sender, EventArgs e)
        {
            if (textBoxOdrediste.Text == "")
            {
                OsvjeziLinije();
            }
            else
            {
                List<Linija> popisLinija = AutobusniKolodvor.DohvatiLinije(textBoxOdrediste.Text);
                dataGridViewLinije.DataSource = null;
                dataGridViewLinije.DataSource = popisLinija;
            }
        }

        private void buttonKupiKartu_Click(object sender, EventArgs e)
        {
            DataGridViewRow linija = dataGridViewLinije.CurrentRow;
            if (linija == null)
            {
                MessageBox.Show("Niste odabrali liniju");
                return;
            }
            else
            {
                var form = new FormKarta(dataGridViewLinije.CurrentRow.DataBoundItem as Linija);
                form.ShowDialog();
            }
        }
    }
}
