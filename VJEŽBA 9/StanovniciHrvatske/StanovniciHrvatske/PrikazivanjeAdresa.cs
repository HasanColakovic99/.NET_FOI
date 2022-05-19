using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanovniciHrvatske
{
    public partial class PrikazivanjeAdresa : Form
    {
        Stanovnici Stanovnik;
        public PrikazivanjeAdresa(Stanovnici stanovnik)
        {
            InitializeComponent();
            Stanovnik = stanovnik;
        }

        private void PrikazivanjeAdresa_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        public void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DohvatiAdrese();
            dataGridView1.Columns["Mjesta"].Visible = false;
            dataGridView1.Columns["Stanovnici"].Visible = false;

        }

        public object DohvatiAdrese()
        {
            using (var context = new LabsEntities())
            {
                context.Stanovnicis.Attach(Stanovnik);
                return Stanovnik.Adrese.ToList();
            }
        }

        private void dodajAdresuButton_Click(object sender, EventArgs e)
        {
            DodavanjeAdrese dodavanjeAdrese = new DodavanjeAdrese(Stanovnik);
            dodavanjeAdrese.ShowDialog();
            Osvjezi();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
