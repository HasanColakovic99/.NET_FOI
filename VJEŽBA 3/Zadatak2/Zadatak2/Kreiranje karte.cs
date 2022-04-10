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
    public partial class Kreiranje_karte : Form
    {
        Linija linija = new Linija();

        public Kreiranje_karte()
        {
            InitializeComponent();
        }
        public Kreiranje_karte(Linija linija)
        {
            InitializeComponent();
            this.linija = linija;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Kreiranje_karte_Load(object sender, EventArgs e)
        {
            polazisteTextBox.Text = linija.Polaziste;
            odredisteTextBox.Text = linija.Odrediste;
            udaljenostTextBox.Text = linija.Udaljenost.ToString();
            prijevoznikTextBox.Text = linija.Autoprijevoznik;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void odaberiteLinijuButton_Click(object sender, EventArgs e)
        {
            PopisAutobusnihLinija popis = new PopisAutobusnihLinija();
            popis.Show();
            this.Hide();
        }

        private void kreirajKartuButton_Click(object sender, EventArgs e)
        {
            VrstaKarte vrstaKarte = new VrstaKarte();
            if(regularnaButton.Checked == true)
            {
                vrstaKarte = VrstaKarte.Regularna;
            }
            else
            {
                vrstaKarte = VrstaKarte.Studentska;
            }

            Karta karta = new Karta(linija, vrstaKarte, povratnaBox.Checked == true, prtljagaBox.Checked == true);
            brKarteTextBox.Text = karta.BrojKarte.ToString();
            cijenaKarteTextBox.Text = karta.Cijena.ToString() + " HRK";
        }
    }
}
