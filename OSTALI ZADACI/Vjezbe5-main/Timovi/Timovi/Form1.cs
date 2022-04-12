using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomoviData;

namespace Timovi
{
    public partial class Form1 : Form
    {
        Klub klub = new Klub();
        Tim tim;
        Nogometas nogometas;
        public Form1()
        {
            InitializeComponent();
        }

        public void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = klub.DostupniNogometasi();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = klub.DohvatiTimove();
            dataGridView3.DataSource = null;
            tim = dataGridView2.CurrentRow.DataBoundItem as Tim;
            dataGridView3.DataSource = klub.DohvatiNogometaseTima(tim);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nogometas = dataGridView1.CurrentRow.DataBoundItem as Nogometas;
            tim.DodajIgracaTimu(nogometas);
            Osvjezi();
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            tim = dataGridView2.CurrentRow.DataBoundItem as Tim;
            dataGridView3.DataSource = klub.DohvatiNogometaseTima(tim);
        }
    }
}
