using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib;

namespace Zadatak6
{
    public partial class Nova_posudba : Form
    {
        public bool posudi;
        public string osoba;
        public Knjiga knjige = new Knjiga();

        public Nova_posudba(Knjiga knjiga)
        {
            InitializeComponent();
            this.knjige = knjiga;
        }

        private void Nova_posudba_Load(object sender, EventArgs e)
        {
            isbnTextBox.Text = knjige.ISBN;
            naslovTextBox.Text = knjige.Naslov;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            posudi = false;
            this.Close();
        }

        private void ureduButton_Click(object sender, EventArgs e)
        {
            this.osoba = osobaTextBox.Text;
            posudi = true;
            Close();
        }
    }
}
