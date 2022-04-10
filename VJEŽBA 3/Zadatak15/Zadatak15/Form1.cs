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

namespace Zadatak15
{
    public partial class Form1 : Form
    {
        List<Vozilo> listaVozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaVozila;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Dodavanje_vozila dodaj = new Dodavanje_vozila(listaVozila);
            dodaj.ShowDialog();
            Osvjezi();
        }

        private void promijeniButton_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = dataGridView1.CurrentRow.DataBoundItem as Vozilo;
            Dodavanje_vozila dodaj = new Dodavanje_vozila(listaVozila, vozilo);
            dodaj.ShowDialog();
        }
    }
}
