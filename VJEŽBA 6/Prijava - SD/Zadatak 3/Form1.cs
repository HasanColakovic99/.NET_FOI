using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_3
{
    public partial class Form1 : Form
    {
        RepozitorijKorisnika korisnik = new RepozitorijKorisnika();
        UpraviteljLozinkama lozinka = new UpraviteljLozinkama();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var Korisnik = korisnik.DohvatiKorisnika(textBox1.Text);
                if (Korisnik == null)
                {
                    throw new NoUserException("Korisnik sa unesenim podacima ne postoji!");
                }
                var Lozinka = lozinka.DohvatiLozinku(Korisnik.ID);

                if (Korisnik.KorisnickoIme == textBox1.Text && Lozinka == textBox2.Text)
                {
                    MessageBox.Show("Uspješno ste se prijavili!");
                }
                else
                {
                    MessageBox.Show("Unijeli ste krive podatke");
                }
            }
            catch (NoUserException ex)
            {
                MessageBox.Show(ex.Poruka);
            } 
        }
    }
}
