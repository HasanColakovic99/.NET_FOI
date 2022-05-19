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
    public partial class PrikazAdresa : Form
    {
        Stanovnici Stanovnik;
        public PrikazAdresa(Stanovnici stanovnik)
        {
            InitializeComponent();
            Stanovnik = stanovnik;
        }

        private void PrikazAdresa_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        public void Osvjezi()
        {
            dataGridView1.DataSource = DohvatiAdrese();
            dataGridView1.Columns["Stanovnici"].Visible = false;
            dataGridView1.Columns["Mjesta"].Visible = false;
        }

        public object DohvatiAdrese()
        {
            using(var context = new LabsEntities())
            {
                context.Stanovnicis.Attach(Stanovnik);
                return Stanovnik.Adrese.ToList();
            }
        }

        private void zatvoriButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajAdresuButton_Click(object sender, EventArgs e)
        {
            DodajAdresu dodajAdresu = new DodajAdresu(Stanovnik);
            dodajAdresu.ShowDialog();
            Osvjezi();
        }

        public Adrese DohvatiAdresu()
        {
            return dataGridView1.CurrentRow.DataBoundItem as Adrese;
        }

        private void azurirajButton_Click(object sender, EventArgs e)
        {
            Adrese adresa = DohvatiAdresu();

            AzurirajAdresu azurirajAdresu = new AzurirajAdresu(adresa, Stanovnik);
            azurirajAdresu.ShowDialog();
            Osvjezi();
        }


        private void obrisiAdresuButton_Click(object sender, EventArgs e)
        {
            Adrese dohvacenaAdresa = dataGridView1.CurrentRow.DataBoundItem as Adrese;
            if (dohvacenaAdresa != null)
            {
                using (var context = new LabsEntities())
                {
                    context.Adrese.Attach(dohvacenaAdresa);
                    context.Adrese.Remove(dohvacenaAdresa);
                    context.SaveChanges();
                }
            }
            Osvjezi();
        }
    }
}
