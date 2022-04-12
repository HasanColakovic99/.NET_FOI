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
    public partial class FormKarta : Form
    {
        private AutobusniKolodvor AutobusniKolodvor { get; set; }
        public Linija AutobusnaLinija { get; set; }

        public FormKarta(Linija linija)
        {
            AutobusniKolodvor = new AutobusniKolodvor();
            AutobusnaLinija = linija;
            InitializeComponent();
        }

        private void buttonIspisiKartu_Click(object sender, EventArgs e)
        {
            Karta kupljenaKarta = null;
            VrstaKarte? vrsta = null;
            if (comboBoxVrstaKarte.SelectedIndex == 0)
            {
                vrsta = VrstaKarte.Regularna;
            }
            if (comboBoxVrstaKarte.SelectedIndex == 1)
            {
                vrsta = VrstaKarte.Studentska;
            }
            if (vrsta == null)
            {
                MessageBox.Show("Odaberite vrstu karte.");
                return;
            }
            kupljenaKarta = AutobusniKolodvor.KupiKartu(AutobusnaLinija, (VrstaKarte)vrsta, checkBoxPovratna.Checked, checkBoxPrtljaga.Checked);

            string povratna = "";
            if (kupljenaKarta.Povratna)
            {
                povratna = "da";
            }
            else
            {
                povratna = "ne";
            }
            string prtljaga = "";
            if (kupljenaKarta.Prtljaga)
            {
                prtljaga = "da";
            }
            else
            {
                prtljaga = "ne";
            }
            textBoxIspis.Text = $"Broj karte: {kupljenaKarta.BrojKarte} {System.Environment.NewLine} Relacija: {kupljenaKarta.Linija.Polaziste} - {kupljenaKarta.Linija.Odrediste} {System.Environment.NewLine} Udaljenost: {kupljenaKarta.Linija.Udaljenost} {System.Environment.NewLine} Autoprijevoznik: {kupljenaKarta.Linija.Autoprijevoznik} {System.Environment.NewLine} Vrsta karte: {kupljenaKarta.Vrsta} {System.Environment.NewLine} Povratna karta: {povratna} {System.Environment.NewLine} Naplatiti prtljagu {prtljaga} {System.Environment.NewLine} ---------------------- {System.Environment.NewLine} Cijena karte {kupljenaKarta.Cijena} kn";
        }
    }
}
