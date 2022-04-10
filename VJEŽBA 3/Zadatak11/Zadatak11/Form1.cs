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
    public partial class Form1 : Form
    {

        public Pitanje pitanja;
        public bool odgovor;
        public Form1()
        {
            InitializeComponent();
        }

        private void pitanjeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }


        public void Pitanja()
        {
            
            Pitanje sljedecePitanje = null;
            odgovor = false;
            // PROVJERAVAMO DA LI IMA JOŠ PITANJA
            // AKO VRATI TRUE ZNAČI IMA, A AKO VRATI FALSE, ZNAČI NEMA
            if (IspitManager.ImaJosPitanja())
            {
                // AKO IMA SLJEDEĆE PITANJE, ONDA TO PITANJE SPREMIMO U VARIJABLU sljedecePitanje
                sljedecePitanje = IspitManager.SljedecePitanje();

                // AKO PITANJE NIJE ODGOVORENO
                if (!sljedecePitanje.JeOdgovoreno())
                {
                    // PRIKAŽI GA U TEXT BOXU PITANJA
                    pitanjeTextBox.Text = sljedecePitanje.Tekst.ToString();

                    // EH SAD NAM TREBAJU ODGOVORI NA TO PITANJE
                    // ONI SU SPREMLJENI U LISTU ODGOVORA
                    pitanja = sljedecePitanje;
                    List<Odgovor> ponudjeniOdgovori = sljedecePitanje.DohvatiOdgovore();
                    // SADA TO PRIKAŽEMO U LIST BOXU
                    listBox.DataSource = ponudjeniOdgovori;
                    potvrdjenOdgovorTextBox.Text = null;
                }
            }
            else
            {
                Rezultati_ispita rezultatiIspita = new Rezultati_ispita();
                rezultatiIspita.ShowDialog();
                this.Hide();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Pitanja();
        }

        private void odgovorButton_Click(object sender, EventArgs e)
        {
            Odgovor potvrdjeniOdgovor = listBox.SelectedItem as Odgovor;
            pitanja.PotvrdiOdgovor(potvrdjeniOdgovor);
            potvrdjenOdgovorTextBox.Text = potvrdjeniOdgovor.Tekst.ToString();
            odgovor = true;
        }

        private void pitanjeButton_Click(object sender, EventArgs e)
        {
            if (odgovor)
            {
                Pitanja();
            }
            else
            {
                MessageBox.Show("Morate potvrditi Vaš odgovor!");
            }
        }
    }
}
