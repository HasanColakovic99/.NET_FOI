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
    public partial class Dodavanje_vozila : Form
    {
        List<Vozilo> listaVozila = new List<Vozilo>();
        public Dodavanje_vozila(List<Vozilo> vozila)
        {
            InitializeComponent();
            this.listaVozila = vozila;
        }

        Vozilo novoVozilo = null;
        public Dodavanje_vozila(List<Vozilo> vozila, Vozilo vozilo)
        {
            InitializeComponent();
            this.listaVozila = vozila;
            this.novoVozilo = vozilo;
        }

        private void Dodavanje_vozila_Load(object sender, EventArgs e)
        {

        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = null;
            if (radioButton1.Checked == true)
            {
                vozilo = new Automobil();
                vozilo.Naziv = textBox1.Text;
                
            }
            else if(radioButton2.Checked == true)
            {
                vozilo = new Motocikl();
                vozilo.Naziv = textBox1.Text;
            }
            listaVozila.Add(vozilo);
            Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
