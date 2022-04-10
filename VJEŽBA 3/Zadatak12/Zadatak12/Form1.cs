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
        Pitanje pitanje;
        IspitManager ispitManager = new IspitManager();
        List<Odgovor> listaOdgovora = new List<Odgovor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pitanje();
        }


        public void PotvrdiOdgovorNaPitanje(int i)
        {
            color = pitanjeTextBox.BackColor;
            ispitManager.PotvrdiPitanje(pitanje, listaOdgovora[i]);
            DisableButton();
            if(pitanje.Status == StatusPitanja.TocnoOdgovoreno)
            {
                pitanjeTextBox.BackColor = Color.Green;
            }
            else if(pitanje.Status == StatusPitanja.NetocnoOdgovoreno)
            {
                pitanjeTextBox.BackColor = Color.Red;
            }
            
        }

        private void DisableButton()
        {
            if(pitanje.Status != StatusPitanja.NijeOdgovoreno)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void EnableButton()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }



        public void Pitanje()
        {
            EnableButton();
            pitanje = ispitManager.SljedecePitanje();
            pitanjeTextBox.Text = pitanje.Tekst.ToString();
            listaOdgovora = ispitManager.DohvatiOdgovore(pitanje);
            button1.Text = "A) " + listaOdgovora[0];
            button2.Text = "B) " + listaOdgovora[1];
            button3.Text = "C) " + listaOdgovora[2];
            button4.Text = "D) " + listaOdgovora[3];
            pitanjeTextBox.BackColor = color;
        }

        public void PrethodnoPitanje()
        {
            EnableButton();
            pitanje = ispitManager.PrethodnoPitanje();
            pitanjeTextBox.Text = pitanje.Tekst.ToString();
            listaOdgovora = ispitManager.DohvatiOdgovore(pitanje);
            button1.Text = "A) " + listaOdgovora[0];
            button2.Text = "B) " + listaOdgovora[1];
            button3.Text = "C) " + listaOdgovora[2];
            button4.Text = "D) " + listaOdgovora[3];
            pitanjeTextBox.BackColor = color;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovorNaPitanje(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovorNaPitanje(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovorNaPitanje(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PotvrdiOdgovorNaPitanje(3);
        }

        private void sljedecePitanjeButton_Click(object sender, EventArgs e)
        {
            Pitanje();
        }

        private void prethodnoPitanjeButton_Click(object sender, EventArgs e)
        {
            PrethodnoPitanje();
        }
    }
}
