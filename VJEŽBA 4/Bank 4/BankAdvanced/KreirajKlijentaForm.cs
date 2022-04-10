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
    public partial class KreirajKlijentaForm : Form
    {
        public KreirajKlijentaForm()
        {
            InitializeComponent();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            Spremi();
            Close();
        }

        private void Spremi()
        {
            string oib = oibTextBox.Text;
            string poduzece = poduzeceTextBox.Text;
            string ime = imeTextBox.Text;
            string prezime = prezimeTextBox.Text;

            if (privatniRadio.Checked == true)
            {
                Banka.KreirajPrivatnogKlijenta(oib, ime, prezime);
            }
            else
            {
                Banka.KreirajPoslovnogKlijenta(oib, poduzece, ime, prezime);
            }
        }

        private void privatniRadio_CheckedChanged(object sender, EventArgs e)
        {
            poduzeceTextBox.Enabled = privatniRadio.Checked == false;
        }
    }
}
