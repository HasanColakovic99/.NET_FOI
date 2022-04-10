using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvedbaIspitaLib2;

namespace Zadatak12
{
    public partial class Form1 : Form
    {
        private Color color;
        IspitManager ispitManager = new IspitManager();
        Pitanje pitanje;
        List<Odgovor> listaOdgovora = new List<Odgovor>();
        public Form1()
        {
            InitializeComponent();
        }


        public void PotvrdiOdgovor(int i)
        {
            color = textBox1.BackColor;
            ispitManager.PotvrdiPitanje(pitanje, listaOdgovora[i]);
            DisableButton();
            if (pitanje.Status == StatusPitanja.TocnoOdgovoreno)
            {
                textBox1.BackColor = Color.Green;
            }
            else if (pitanje.Status == StatusPitanja.NetocnoOdgovoreno)
            {
                textBox1.BackColor = Color.Red;
            }

        }

        public void DisableButton()
        {
            if(pitanje.Status != StatusPitanja.NijeOdgovoreno)
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        public void EnableButton()
        {
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        public void SljedecePitanje()
        {
            EnableButton();
            pitanje = ispitManager.SljedecePitanje();
            textBox1.Text = pitanje.Tekst.ToString();
            listaOdgovora = ispitManager.DohvatiOdgovore(pitanje);
            button3.Text = "A) " + listaOdgovora[0];
            button4.Text = "B) " + listaOdgovora[1];
            button5.Text = "C) " + listaOdgovora[2];
            button6.Text = "D) " + listaOdgovora[3];
            textBox1.BackColor = color;
        }

        public void PrethodnoPitanje()
        {
            pitanje = ispitManager.PrethodnoPitanje();
            textBox1.Text = pitanje.Tekst.ToString();
            listaOdgovora = ispitManager.DohvatiOdgovore(pitanje);
            button3.Text = "A) " + listaOdgovora[0];
            button4.Text = "B) " + listaOdgovora[1];
            button5.Text = "C) " + listaOdgovora[2];
            button6.Text = "D) " + listaOdgovora[3];
            textBox1.BackColor = color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SljedecePitanje();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnableButton();
            PrethodnoPitanje();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SljedecePitanje();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovor(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovor(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovor(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovor(3);
        }
    }
}
