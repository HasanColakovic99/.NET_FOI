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
    public partial class DetaljiKlijentaForm : Form
    {
        private IKlijent _klijent;
        public DetaljiKlijentaForm(IKlijent klijent)
        {
            InitializeComponent();
            _klijent = klijent;
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetaljiKlijentaForm_Load(object sender, EventArgs e)
        {
            PrikaziPodatkeKlijenta();
        }

        private void PrikaziPodatkeKlijenta()
        {
            if (_klijent.Tip == TipKlijenta.Privatni)
            {
                PrikaziPrivatnogKlijenta(_klijent as PrivatniKlijent);
            }
            else
            {
                PrikaziPoslovnogKlijenta(_klijent as PoslovniKlijent);
            }
        }

        private void PrikaziPrivatnogKlijenta(PrivatniKlijent klijent)
        {
            oibTextBox.Text = klijent.Osoba.OIB;
            imeTextBox.Text = klijent.Osoba.Ime;
            prezimeTextBox.Text = klijent.Osoba.Prezime;
            privatniRadio.Checked = true;
            poduzeceTextBox.Enabled = false;
        }

        private void PrikaziPoslovnogKlijenta(PoslovniKlijent klijent)
        {
            oibTextBox.Text = klijent.Osoba.OIB;
            imeTextBox.Text = klijent.Osoba.Ime;
            prezimeTextBox.Text = klijent.Osoba.Prezime;
            poslovniRadio.Checked = true;
            poduzeceTextBox.Text = klijent.NazivPoduzeca;
            poduzeceTextBox.Enabled = true;
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            SpremiKlijenta();
            Close();
        }

        private void SpremiKlijenta()
        {
            if (_klijent.Tip == TipKlijenta.Privatni)
            {
                SpremiPrivatnogKlijenta(_klijent as PrivatniKlijent);
            }
            else
            {
                SpremiPoslovnogKlijenta(_klijent as PoslovniKlijent);
            }
        }

        private void SpremiPoslovnogKlijenta(PoslovniKlijent klijent)
        {
            klijent.Osoba.OIB = oibTextBox.Text;
            klijent.Osoba.Ime = imeTextBox.Text;
            klijent.Osoba.Prezime = prezimeTextBox.Text;
            klijent.NazivPoduzeca = poduzeceTextBox.Text;
        }

        private void SpremiPrivatnogKlijenta(PrivatniKlijent klijent)
        {
            klijent.Osoba.OIB = oibTextBox.Text;
            klijent.Osoba.Ime = imeTextBox.Text;
            klijent.Osoba.Prezime = prezimeTextBox.Text;
        }
    }
}
