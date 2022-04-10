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

namespace Vozila_Forms_DllRef
{
    public partial class FrmPodaci : Form
    {
        public List<Vozilo> Vozila { get; }
        private Vozilo Vozilo { get; set; }

        /// <summary>
        /// Konstruktor koji služi za dodavanje novog vozila. 
        /// Novo vozilo se dodaje u listu vozila.
        /// U ovoj metodi nema pogreške.
        /// </summary>
        /// <param name="vozila"></param>
        public FrmPodaci(List<Vozilo> vozila)
        {
            //U ovoj metodi nema pogreške.
            InitializeComponent();
            Vozila = vozila;
            Vozilo = null;
        }

        /// <summary>
        /// Konstruktor koji služi za prihvaćanje vozila kojeg treba izmijeniti.
        /// U ovoj metodi nema pogreške.
        /// </summary>
        /// <param name="vozilo"></param>
        public FrmPodaci(Vozilo vozilo)
        {
            //U ovoj metodi nema pogreške.
            InitializeComponent();
            Vozilo = vozilo;
            Vozila = null;
            PostaviFormuZaPromjene();
        }

        private void PostaviFormuZaPromjene()
        {
            txtNaziv.Text = Vozilo.Naziv;
            if (Vozilo.Tip == "Automobil")
                rbAutomobil.Checked = true;
            else
                rbMotocikl.Checked = true;
            groupBox1.Enabled = false;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (Vozilo != null)
            {
                Vozilo.Naziv = txtNaziv.Text;
            }
            else
            {
                if (rbAutomobil.Checked)
                    Vozilo = new Automobil();
                else
                    Vozilo = new Automobil();
                Vozilo.Naziv = txtNaziv.Text;

                Vozila.Add(Vozilo);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
