using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace Zadatak9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void DohvatiTransakcije()
        {
            List<Transakcija> listaTransakcija = Banka.DohvatiPopisTransakcija();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaTransakcija;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DohvatiTransakcije();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banka.StornirajTransakciju(dataGridView1.CurrentRow.DataBoundItem as Transakcija);
            DohvatiTransakcije();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Provedi_transakciju provedi = new Provedi_transakciju();
            provedi.ShowDialog();
            DohvatiTransakcije();
        }
    }
}
