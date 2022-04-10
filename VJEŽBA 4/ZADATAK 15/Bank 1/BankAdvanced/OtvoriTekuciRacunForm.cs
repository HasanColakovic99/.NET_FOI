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
    public partial class OtvoriTekuciRacunForm : Form
    {
        private IKlijent _odabraniKlijent;
        public OtvoriTekuciRacunForm()
        {
            InitializeComponent();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            string iban = ibanTextBox.Text;
            double pocetnoStanje = double.Parse(stanjeTextBox.Text);
            double dozvoljeniMinus = double.Parse(dozvoljeniMinusTextBox.Text);

            Banka.OtvoriTekuciRacun(iban, pocetnoStanje, dozvoljeniMinus, _odabraniKlijent);

            Close();
        }

        private void OtvoriTekuciRacunForm_Load(object sender, EventArgs e)
        {
            InicijalizirajPodatke();
        }

        private void InicijalizirajPodatke()
        {
            ibanTextBox.Text = Banka.GenerirajJedinstvenIBAN();
            Valuta hrk = Repozitorij.DohvatiValutu("HRK");
            valutaTextBox.Text = hrk.ToString();
            stanjeTextBox.Text = "0";
            dozvoljeniMinusTextBox.Text = "0";
        }

        private void odabirKlijentaButton_Click(object sender, EventArgs e)
        {
            OdaberiKlijentaForm form = new OdaberiKlijentaForm();
            form.ShowDialog();

            _odabraniKlijent = form.OdabraniKlijent;
            klijentTextBox.Text = _odabraniKlijent.Opis;
        }
    }
}
