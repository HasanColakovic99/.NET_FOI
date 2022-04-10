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
        Linija linije;
        public Kupi_kartu(Linija linija)
        {
            InitializeComponent();
            this.linije = linija;
        }

        private void Kupi_kartu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VrstaKarte vrsta = new VrstaKarte();
            if(comboBox1.SelectedIndex == 0)
            {
                vrsta = VrstaKarte.Regularna;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                vrsta = VrstaKarte.Studentska;
            }
            Karta karta = new Karta(linije, vrsta, checkBox1.Checked == true, checkBox2.Checked == true);
            AutobusniKolodvor kolodvor = new AutobusniKolodvor();
            kolodvor.KupiKartu(linije, vrsta, checkBox1.Checked == true, checkBox2.Checked == true);
            textBox1.Text = $"Broj karte: {karta.BrojKarte}\r\nRelcija: {linije.Polaziste} {linije.Odrediste}\r\nUdaljenost: {linije.Udaljenost}\r\nAutoprijevoznik: {linije.Autoprijevoznik}\r\nVrsta karte: {karta.Vrsta}\r\nPovratna karta: {karta.Povratna}\r\nNaplati prtljagu: {karta.Prtljaga}\r\n--------------------\r\n\nCijena karte: {karta.Cijena}";
        }
    }
}
