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
    public partial class OtvoriDevizniRacunForm : Form
    {
        private IKlijent _odabraniKlijent;
        private Valuta _odabranaValuta;

        public OtvoriDevizniRacunForm()
        {
            InitializeComponent();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            string iban = ibanTextBox.Text;
            double pocetnoStanje = double.Parse(stanjeTextBox.Text);

            Banka.OtvoriDevizniRacun(iban, pocetnoStanje, _odabranaValuta.Oznaka, _odabraniKlijent);

            Close();
        }

        private void odabirValuteButton_Click(object sender, EventArgs e)
        {
            OdaberiValutuForm form = new OdaberiValutuForm();
            form.ShowDialog();

            _odabranaValuta = form.OdabranaValuta;
            valutaTextBox.Text = _odabranaValuta.ToString();
        }

        private void odabirKlijentaButton_Click(object sender, EventArgs e)
        {
            OdaberiKlijentaForm form = new OdaberiKlijentaForm();
            form.ShowDialog();

            if (form.OdabraniKlijent != null)
            {
                _odabraniKlijent = form.OdabraniKlijent;
            }
            PrikaziOdabranogKlijenta();
        }

        private void PrikaziOdabranogKlijenta()
        {
            if (_odabraniKlijent != null)
            {
                klijentTextBox.Text = _odabraniKlijent.Opis;
            }
        }

        private void InicijalizirajPodatke()
        {
            ibanTextBox.Text = Banka.GenerirajJedinstvenIBAN();
            stanjeTextBox.Text = "0";
        }

        private void OtvoriDevizniRacunForm_Load(object sender, EventArgs e)
        {
            InicijalizirajPodatke();
        }
    }
}
