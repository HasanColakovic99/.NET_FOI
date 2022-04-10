using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace Zadatak4
{
    public partial class Detalji : Form
    {
        public Transakcija transakcije;
        public Detalji(Transakcija transakcija)
        {
            InitializeComponent();
            this.transakcije = transakcija;
        }

        private void Detalji_Load(object sender, EventArgs e)
        {
            IBANtextbox.Text = transakcije.Platitelj.IBAN;
            vlasnikTextBox.Text = transakcije.Platitelj.Vlasnik;
            textBox3.Text = transakcije.Platitelj.Stanje.ToString();
            textBox4.Text = transakcije.Platitelj.IzracunajUkupanPromet().ToString();
        }
    }
}
