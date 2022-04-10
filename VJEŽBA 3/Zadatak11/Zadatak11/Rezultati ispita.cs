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

namespace Zadatak11
{
    public partial class Rezultati_ispita : Form
    {
        public Rezultati_ispita()
        {
            InitializeComponent();
        }

        private void Rezultati_ispita_Load(object sender, EventArgs e)
        {
            List<Pitanje> listaPitanja = IspitManager.DohvatiRezultate();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPitanja;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
