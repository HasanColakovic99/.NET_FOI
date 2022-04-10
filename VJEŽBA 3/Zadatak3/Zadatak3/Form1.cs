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

namespace Zadatak3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        List<Linija> linije;
        private void Form1_Load(object sender, EventArgs e)
        {
            AutobusniKolodvor kolodvor = new AutobusniKolodvor();
            linije = kolodvor.DohvatiLinije();
            linijeDataGridView.DataSource = null;
            linijeDataGridView.DataSource = linije;
        }

        private void pronadjiButton_Click(object sender, EventArgs e)
        {
            List<Linija> noveLinije = new List<Linija>();
            
            foreach(Linija item in linije)
            {
                if(item.Odrediste == odredisteTextBox.Text)
                {
                    noveLinije.Add(item);
                }
            }

            if(noveLinije.Count != 0)
            {
                linijeDataGridView.DataSource = noveLinije;
            }

        }

        private void kupiKartuButton_Click(object sender, EventArgs e)
        {
            Linija linija = linijeDataGridView.CurrentRow.DataBoundItem as Linija;
            Kupi_kartu karta = new Kupi_kartu(linija);
            this.Hide();
            karta.Show();            
        }
    }
}
