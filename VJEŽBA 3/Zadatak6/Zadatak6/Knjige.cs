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
    public partial class Knjige : Form
    {
        public Knjiznica knjiznica = new Knjiznica();
        List<Knjiga> dostupneKnjige = new List<Knjiga>();
        List<Knjiga> posudjeneKnjige = new List<Knjiga>();
        public Knjige()
        {
            InitializeComponent();
        }

        

        private void DostupneKnjige()
        {
            dostupneKnjige = knjiznica.DohvatiDostupneKnjige();
            dostupneKnjigeDataGridView.DataSource = null;
            dostupneKnjigeDataGridView.DataSource = dostupneKnjige;
        }

        private void KnjigeNaPosudbi()
        {
            posudjeneKnjige = knjiznica.DohvatiKnjigeNaPosudbi();
            posudjeneKnjigeDataGridView.DataSource = null;
            posudjeneKnjigeDataGridView.DataSource = posudjeneKnjige;
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            DostupneKnjige();
            KnjigeNaPosudbi();
        }

        private void posudiButton_Click(object sender, EventArgs e)
        {
            Knjiga currentLinija = dostupneKnjigeDataGridView.CurrentRow.DataBoundItem as Knjiga;
            Nova_posudba nova_posudba = new Nova_posudba(currentLinija);
            
            nova_posudba.ShowDialog();

            if (nova_posudba.posudi == true)
            {
                knjiznica.PosudiKnjigu(nova_posudba.knjige, nova_posudba.osoba);
            }

            DostupneKnjige();
            KnjigeNaPosudbi();
        }

        private void Refresh(object sender, EventArgs e)
        {
            DostupneKnjige();
            KnjigeNaPosudbi();
        }

        private void vratiButton_Click(object sender, EventArgs e)
        {
            knjiznica.VratiKnjigu(posudjeneKnjigeDataGridView.CurrentRow.DataBoundItem as Knjiga);
            DostupneKnjige();
            KnjigeNaPosudbi();
        }
    }
}
