using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_1
{
    public partial class Form1 : Form
    {
        Repozitorij repozitorij = new Repozitorij();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public void OtvoriVrata(int brVrata)
        {
            Korisnik korisnik = repozitorij.DohvatiKorisnika(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Vrata vrata = repozitorij.DohvatiVrata(brVrata);
            try
            {
                if (korisnik == null)
                {
                    throw new NoUserException("Unijeli ste krive podatke!");
                }
                if (korisnik.BrojKartice == int.Parse(textBox1.Text) && korisnik.PIN == int.Parse(textBox2.Text) && (korisnik.RazinaPrava == vrata.RazinaPrava || korisnik.RazinaPrava > vrata.RazinaPrava))
                {
                    MessageBox.Show("Vrata uspješno otvorena!");
                }
                else
                {
                    MessageBox.Show("Ne možete otvoriti ta vrata!");
                }
            }
            catch (NoUserException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtvoriVrata(501);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OtvoriVrata(502);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OtvoriVrata(503);
        }
    }
}
