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
    public partial class FormGlavna : Form
    {
        public List<Vozilo> vozila = new List<Vozilo>();
        public FormGlavna()
        {
            InitializeComponent();
        }

        private void FormGlavna_Load(object sender, EventArgs e)
        {
            PrikaziVozila();
        }

        private void PrikaziVozila()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = vozila;
            dataGridViewVozila.DataSource = null;
            dataGridViewVozila.DataSource = bindingSource;
        }

        private void ButtonDodajVozilo_Click(object sender, EventArgs e)
        {
            using (FormDodavanjeVozila novaForma = new FormDodavanjeVozila())
            {
                DialogResult rezultat = novaForma.ShowDialog();
                if(rezultat == DialogResult.OK)
                {
                    foreach (Vozilo item in novaForma.vozila)
                    {
                        vozila.Add(item);
                    }
                }
            }
            PrikaziVozila();
        }

        private void ButtonPromijeniNaziv_Click(object sender, EventArgs e)
        {
            Vozilo odabranoVozilo = dataGridViewVozila.CurrentRow.DataBoundItem as Vozilo;
            using (FormPromijeni novaForma = new FormPromijeni(odabranoVozilo))
            {
                DialogResult rezultat = novaForma.ShowDialog();
                if(rezultat == DialogResult.OK)
                {
                    odabranoVozilo = novaForma.trenutnoVozilo;
                }
            }
            PrikaziVozila();
        }

        private void ButtonObrisiVozilo_Click(object sender, EventArgs e)
        {
            Vozilo odabranoVozilo = dataGridViewVozila.CurrentRow.DataBoundItem as Vozilo;
            vozila.Remove(odabranoVozilo);
            PrikaziVozila();
        }
    }
}
