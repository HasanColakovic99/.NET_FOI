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

namespace Provedba_ispita
{
    public partial class FormGlavna : Form
    {
        public Pitanje pitanja;
        public bool odgovor;
        public FormGlavna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            Pitanje sljedecePitanje = null;
            odgovor = false;
            // AKO IMA JOŠ PITANJA
            if (IspitManager.ImaJosPitanja())
            {
                // sljedecePitanje POPRIMA SLJEDEĆE PITANJE
                sljedecePitanje = IspitManager.SljedecePitanje();

                // AKO KORISNIK NIJE ODGOVORIO NA TO PITANJE
                if (!sljedecePitanje.JeOdgovoreno())
                {
                    // PITANJE STAVLJAMO U TEXT BOX
                    textBoxPitanje.Text = sljedecePitanje.Tekst.ToString();
                    
                    // UZ POMOĆ LISTE PRIKAZUJEMO PONUĐENE ODGOVORE NA POSTAVLJENO PITANJE
                    pitanja = sljedecePitanje;
                    List<Odgovor> moguciOdgovori = sljedecePitanje.DohvatiOdgovore();
                    textBoxPotvrdeniOdgovor.Text = null;
                    listBoxMoguciOdgovori.DataSource = moguciOdgovori;   
                }
            } 
            else
            {
                FormRezultati novaForma = new FormRezultati();
                novaForma.ShowDialog();
            }
        }

        private void ButtonPotvrdiOdgovor_Click(object sender, EventArgs e)
        {
            Odgovor pitalica = listBoxMoguciOdgovori.SelectedItem as Odgovor;
            pitanja.PotvrdiOdgovor(pitalica);
            textBoxPotvrdeniOdgovor.Text = pitanja.TocanOdgovor.ToString();
            odgovor = true;
        }

        private void ButtonSljedecePitanje_Click(object sender, EventArgs e)
        {
            if (odgovor)
            {
                Osvjezi();
            }
            else
            {
                MessageBox.Show("Morate potvrditi odgovor");
            }
        }
    }
}
