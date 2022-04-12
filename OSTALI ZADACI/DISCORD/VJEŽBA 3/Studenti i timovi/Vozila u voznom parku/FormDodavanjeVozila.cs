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
    public partial class FormDodavanjeVozila : Form
    {
        public List<Vozilo> vozila = new List<Vozilo>();
        public Vozilo novoVozilo = new Automobil();
        public Vozilo noviMotor = new Motocikl();
        public FormDodavanjeVozila()
        {
            InitializeComponent();
        }

        private void ButtonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSpremi_Click(object sender, EventArgs e)
        {
            if (radioButtonAutomobil.Checked)
            {
                novoVozilo.Naziv = textBoxNazivVozila.Text;
                vozila.Add(novoVozilo);
            }
            else
            {
                noviMotor.Naziv = textBoxNazivVozila.Text;
                vozila.Add(noviMotor);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
