using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;
namespace Zadatak2
{
    public partial class Kreiranje_karte : Form
    {
        Linija linije = new Linija();
        public Kreiranje_karte()
        {
            InitializeComponent();
        }

        public Kreiranje_karte(Linija linija)
        {
            InitializeComponent();
            this.linije = linija;
        }

        private void Kreiranje_karte_Load(object sender, EventArgs e)
        {
            textBox1.Text = linije.Polaziste;
            textBox2.Text = linije.Odrediste;
            textBox3.Text = linije.Udaljenost.ToString();
            textBox4.Text = linije.Autoprijevoznik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 forma = new Form1();
            this.Hide();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VrstaKarte vrsta = new VrstaKarte();
            if(radioButton1.Checked == true)
            {
                vrsta = VrstaKarte.Regularna;
            }
            else if(radioButton2.Checked == true)
            {
                vrsta = VrstaKarte.Studentska;
            }
            Karta karta = new Karta(linije, vrsta,checkBox1.Checked == true, checkBox2.Checked == true);
            textBox5.Text = karta.BrojKarte.ToString();
            textBox6.Text = karta.Cijena.ToString();
        }
    }
}
