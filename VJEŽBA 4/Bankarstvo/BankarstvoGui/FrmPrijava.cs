using BankarstvoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankarstvoGui
{
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        { 
            try
            {
                string korisnickoIme = txtKorisnickoIme.Text;
                string lozinka = txtLozinka.Text;
                Autentifikator.Prijavi(korisnickoIme, lozinka);

                if (Autentifikator.PrijavljeniKorisnik.KorisnickoIme == korisnickoIme && Autentifikator.PrijavljeniKorisnik.Lozinka == lozinka)
                {
                    Close();
                }
                else
                {
                    PonovniPokusaj();
                }
            }
            catch (BankarstvoLib.AuthenticationException ex)
            {
                MessageBox.Show(ex.Poruka);
            }

            
        }

        private void PonovniPokusaj()
        {
            OcistiUnos();
            //MessageBox.Show("Unijeti podaci nisu ispravni, molimo vas pokušajte ponovno!");
        }

        private void OcistiUnos()
        {
            txtKorisnickoIme.Clear();
            txtLozinka.Clear();
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {

        }
    }
}
