using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkladisteData;

namespace SkladisteForm
{
    public partial class Form1 : Form
    {
        Skladiste skladiste = new Skladiste();
        IArtikli artikl;
        public Form1()
        {
            InitializeComponent();
        }

        public void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = skladiste.DohvatiArtikle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                skladiste.DodajDomaciProizvod(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            }
            else if(radioButton2.Checked == true)
            {
                skladiste.DodajUvezeniProizvod(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            }
            Osvjezi();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            artikl = dataGridView1.CurrentRow.DataBoundItem as IArtikli;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            artikl.DodajKolicinu();
            Osvjezi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            artikl.OduzmiKolicinu();
            Osvjezi();
        }
    }
}
