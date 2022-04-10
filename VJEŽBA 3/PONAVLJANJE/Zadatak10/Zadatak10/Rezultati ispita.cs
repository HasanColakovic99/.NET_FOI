using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvedbaIspitaLib;

namespace Zadatak10
{
    public partial class Rezultati_ispita : Form
    {
        public Rezultati_ispita()
        {
            InitializeComponent();
        }

        private void Rezultati_ispita_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = IspitManager.DohvatiRezultate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
