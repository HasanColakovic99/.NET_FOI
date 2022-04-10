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
    public partial class Kupi_kartu : Form
    {
        Linija linija;
        public Kupi_kartu(Linija linije)
        {
            InitializeComponent();
            this.linija = linije;
        }

        private void Kupi_kartu_Load(object sender, EventArgs e)
        {
            
        }

        private void ispisKarteButton_Click(object sender, EventArgs e)
        {
            VrstaKarte vrsta = new VrstaKarte();
            if(comboBox.SelectedIndex == 0)
            {
                vrsta = VrstaKarte.Regularna;
            }
            else if (comboBox.SelectedIndex == 1)
            {
                vrsta = VrstaKarte.Studentska;
            }
            Karta karta = new Karta(linija, vrsta, povrtnaCheckBox.Checked == true, prtljagaCheckBox.Checked == true);

            string ispis = $"Broj karte: {karta.BrojKarte}\r\nRelacija: {linija.Polaziste} - {linija.Odrediste}\r\nUdaljenost: {linija.Udaljenost}\r\nAutoprijevoznik: {linija.Autoprijevoznik}\r\nVrsta karte: {karta.Vrsta}\r\nPovratna karta: {karta.Povratna}\r\nNaplati prtljag: {karta.Prtljaga}\r\n-----------------\r\nCijena karte: {karta.Cijena}";
            textBox1.Text = ispis;
        }


    }
}
