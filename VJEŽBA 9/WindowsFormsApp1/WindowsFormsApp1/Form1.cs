using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        public void Osvjezi()
        {
            dataGridView1.DataSource = getStanovnici();
            dataGridView1.Columns["Adrese"].Visible = false;
        }

        public object getStanovnici()
        {
            using(var context = new LabsEntities())
            {
                return context.Stanovnicis.ToList();
            }
        }

        private void dodajStanovnikaButton_Click(object sender, EventArgs e)
        {
            Stanovnik stanovnik = new Stanovnik();
            stanovnik.ShowDialog();
            Osvjezi();
        }

        private Stanovnici DohvatiStanovnika()
        {
            return dataGridView1.CurrentRow.DataBoundItem as Stanovnici;
        }

        private void prikaziAdreseButton_Click(object sender, EventArgs e)
        {
            Stanovnici stanovnik = DohvatiStanovnika();
            PrikazAdresa adrese = new PrikazAdresa(stanovnik);
            adrese.ShowDialog();
            Osvjezi();
        }
    }
}
