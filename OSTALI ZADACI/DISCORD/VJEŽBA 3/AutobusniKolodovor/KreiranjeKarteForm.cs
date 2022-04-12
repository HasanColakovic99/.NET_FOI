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
    public partial class KreiranjeKarteForm : Form
    {
        public Linija OdabranaLinija { get; set; }
        public KreiranjeKarteForm()
        {
            InitializeComponent();
        }
       
        private void OdaberiteLinijuButton_Click(object sender, EventArgs e)
        {
            using(var form = new PopisLinijaForm()) 
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    OdabranaLinija = form.OdabranaLinja;
                    this.polazisteTextBox.Text = OdabranaLinija?.Polaziste;
                    this.odredisteTextBox.Text = OdabranaLinija?.Odrediste;
                    this.udaljenostTextBox.Text = OdabranaLinija?.Udaljenost.ToString();
                    this.autoprijevoznikTextBox.Text = OdabranaLinija?.Autoprijevoznik;
                }
            }
        }

        private void kreiranjeButton_Click(object sender, EventArgs e)
        {
            VrstaKarte vrstaKarte = this.regularnaRadio.Checked ? VrstaKarte.Regularna : VrstaKarte.Studentska;
            bool povratnaKarta = this.povratnaCheck.Checked;
            bool prtljaga = this.prtljagaCheck.Checked;
            Karta novaKarta = AutobusniKolodvor.KreirajKartu(OdabranaLinija, vrstaKarte, povratnaKarta, prtljaga);
            this.brojKarteTextBox.Text = novaKarta.BrojKarte.ToString();
            this.cijenaTextBox.Text = novaKarta.Cijena.ToString();
        }
    }
}
