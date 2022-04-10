using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studenti
{
    public partial class Form1 : Form
    {
        Unos unos = new Unos();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btrDodajStudenta_Click(object sender, EventArgs e)
        {
            TextBox Ime = tbxIme;
            string Prezime = tbxPrezime.Text;
          
            unos.unesiStudenta(new Student(Ime, Prezime));
            OsvjeziPopisStudenata();
        }

        private void btrDodajPredmet_Click(object sender, EventArgs e)
        {
            try
            {
                string Naziv = tbxNaziv.Text;
                unos.unesiPredmet(new Predmet(Naziv));
                OsvjeziPopisPredmeta();
            }
            catch (PredmetException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void OsvjeziPopisStudenata()
        {  
            dgvPredmet.DataSource = null;
            dgvPredmet.DataSource = unos.DohvatiStudenta();
        }

        private void OsvjeziPopisPredmeta()
        {
            dgvStudent.DataSource = null;
            dgvStudent.DataSource = unos.DohvatiPredmet();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // throw new Exception("neka čudna greška na početku");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
