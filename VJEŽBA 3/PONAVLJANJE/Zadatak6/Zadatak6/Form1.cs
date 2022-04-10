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
    public partial class Form1 : Form
    {
        List<Knjiga> listaDostupnihKnjiga = new List<Knjiga>();
        List<Knjiga> listaPosudjenihKnjiga = new List<Knjiga>();
        Knjiznica knjiznica = new Knjiznica();
        public Form1()
        {
            InitializeComponent();
        }


        private void DostupneKnjige()
        {
            listaDostupnihKnjiga = knjiznica.DohvatiDostupneKnjige();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDostupnihKnjiga;
        }

        private void PosudjeneKnjige()
        {
            listaPosudjenihKnjiga = knjiznica.DohvatiKnjigeNaPosudbi();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaPosudjenihKnjiga;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DostupneKnjige();
            PosudjeneKnjige();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Knjiga currentKnjiga = dataGridView1.CurrentRow.DataBoundItem as Knjiga;
            Nova_posudba novaPosudba = new Nova_posudba(currentKnjiga);
            novaPosudba.ShowDialog();

            if(novaPosudba.posudi == true)
            {
                knjiznica.PosudiKnjigu(currentKnjiga, novaPosudba.osoba);
            }

            DostupneKnjige();
            PosudjeneKnjige();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            knjiznica.VratiKnjigu(dataGridView2.CurrentRow.DataBoundItem as Knjiga);
            DostupneKnjige();
            PosudjeneKnjige();
        }
    }
}
