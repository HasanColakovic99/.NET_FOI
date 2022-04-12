using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vozila;

namespace Vozila_u_voznom_parku
{
    public partial class FormPromijeni : Form
    {
        public Vozilo trenutnoVozilo;
        public FormPromijeni(Vozilo odabranoVozilo)
        {
            InitializeComponent();
            trenutnoVozilo = odabranoVozilo;
        }

        private void ButtonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSpremi_Click(object sender, EventArgs e)
        {
            trenutnoVozilo.Naziv = textBoxNazivVozila.Text; 
            this.DialogResult = DialogResult.OK;
        }

        private void FormPromijeni_Load(object sender, EventArgs e)
        {
            if (trenutnoVozilo.Tip == "Automobil")
                radioButtonAutomobil.Checked = true;
            else
                radioButtonMotocikli.Checked = true;
        }
    }
}
