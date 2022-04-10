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

namespace Zadatak10
{
    public partial class Form1 : Form
    {
        Pitanje pitanje;
        public bool odgovoreno;
        public Form1()
        {
            InitializeComponent();
        }


        private void Pitanje()
        {
            Pitanje sljedecePitanje = null;
            odgovoreno = false;
            if (IspitManager.ImaJosPitanja())
            {
                sljedecePitanje = IspitManager.SljedecePitanje();

                if (!sljedecePitanje.JeOdgovoreno())
                {
                    textBox1.Text = sljedecePitanje.Tekst.ToString();
                    pitanje = sljedecePitanje;
                    List<Odgovor> listaOdgovora = pitanje.DohvatiOdgovore();
                    listBox1.DataSource = listaOdgovora;
                    textBox2.Text = null;
                }
            }
            else
            {
                Rezultati_ispita rezultati = new Rezultati_ispita();
                this.Hide();
                rezultati.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pitanje();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Odgovor odgovor = listBox1.SelectedItem as Odgovor;
            pitanje.PotvrdiOdgovor(odgovor);
            textBox2.Text = odgovor.Tekst.ToString();
            odgovoreno = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (odgovoreno)
            {
                Pitanje();
            }
            else
            {
                MessageBox.Show("Morate potvrditi odgovor!");
            }
        }
    }
}
