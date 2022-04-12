using ProvedbaIspitaLib2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Provedba_ispita_2
{
    public partial class FormGlavna : Form
    {
        public IspitManager ispitMenadzer = new IspitManager();
        public Pitanje odabranoPitanje;
        List<Odgovor> odgovoriPitanja = new List<Odgovor>();
        public FormGlavna()
        {
            InitializeComponent();
        }

        private void FormGlavna_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            odabranoPitanje = ispitMenadzer.SljedecePitanje();
            textBoxPitanje.Text = odabranoPitanje.Tekst;
            //Ovo dolje je kod za to da se textbox oboja u sivo kao u zadatku al sam iskljucio jer ne vidim nis procitat ođe
            //textBoxPitanje.BackColor = Color.Gray;
            odgovoriPitanja = ispitMenadzer.DohvatiOdgovore(odabranoPitanje);
            ButtonOdgovor1.Text = "A) " + odgovoriPitanja[0].Tekst;
            ButtonOdgovor2.Text = "B) " + odgovoriPitanja[1].Tekst;
            ButtonOdgovor3.Text = "C) " + odgovoriPitanja[2].Tekst;
            ButtonOdgovor4.Text = "D) " + odgovoriPitanja[3].Tekst;
            ProvjeriButtone();
        }

        private void ButtonSljedecePitanje_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void ButtonPrethodnoPitanje_Click(object sender, EventArgs e)
        {
            OsvjeziPrethodno();
        }

        private void OsvjeziPrethodno()
        {
            odabranoPitanje = ispitMenadzer.PrethodnoPitanje();
            textBoxPitanje.Text = odabranoPitanje.Tekst;
            //Ovo dolje je kod za to da se textbox oboja u sivo kao u zadatku al sam iskljucio jer ne vidim nis procitat ođe
            //textBoxPitanje.BackColor = Color.Gray;
            odgovoriPitanja = null;
            odgovoriPitanja = ispitMenadzer.DohvatiOdgovore(odabranoPitanje);
            ButtonOdgovor1.Text = "A) " + odgovoriPitanja[0].Tekst;
            ButtonOdgovor2.Text = "B) " + odgovoriPitanja[1].Tekst;
            ButtonOdgovor3.Text = "C) " + odgovoriPitanja[2].Tekst;
            ButtonOdgovor4.Text = "D) " + odgovoriPitanja[3].Tekst;
            ProvjeriButtone();
        }

        private void ProvjeriButtone()
        {
            if(odabranoPitanje.Status != StatusPitanja.NijeOdgovoreno)
            {
                ButtonOdgovor1.Enabled = false;
                ButtonOdgovor2.Enabled = false;
                ButtonOdgovor3.Enabled = false;
                ButtonOdgovor4.Enabled = false;
            }
        }

        private void ButtonOdgovor1_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovor(0);
        }

        private void PotvrdiOdgovor(int i)
        {
            ispitMenadzer.PotvrdiPitanje(odabranoPitanje, odgovoriPitanja[i]);
            if (odabranoPitanje.Status == StatusPitanja.TocnoOdgovoreno)
            {
                textBoxPitanje.BackColor = Color.Green;
            } else
            {
                textBoxPitanje.BackColor = Color.Red;
            }
        }

        private void ButtonOdgovor2_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovor(1);
        }

        private void ButtonOdgovor3_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovor(2);
        }

        private void ButtonOdgovor4_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovor(3);
        }
    }
}
