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
        Knjiga knjige = new Knjiga();
        public Nova_posudba(Knjiga knjiga)
        {
            InitializeComponent();
            this.knjige = knjiga;
        }

        private void Nova_posudba_Load(object sender, EventArgs e)
        {
            textBox1.Text = knjige.ISBN;
            textBox2.Text = knjige.Naslov;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            posudi = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.osoba = textBox3.Text;
            posudi = true;
            this.Close();
        }
    }
}
