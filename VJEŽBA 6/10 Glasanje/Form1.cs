using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Glasanje
{
    public partial class Form1 : Form
    {
        Glasanje glasanje = new Glasanje();
        private int z = 0, p = 0, s = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelZa.Text = 0.ToString();
            labelProtiv.Text = 0.ToString();
            labelSuzdrzan.Text = 0.ToString();
        }

        private void OsvjeziRezultate()
        {
            if (glasanje.odabranaOpcija == "ZA")
            {
                z++;
                labelZa.Text = z.ToString();
            }
            else if (glasanje.odabranaOpcija == "PROTIV")
            {
                p++;
                labelProtiv.Text = p.ToString();
            }
            else if (glasanje.odabranaOpcija == "SUZDRZAN")
            {
                s++;
                labelSuzdrzan.Text = s.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool mozeGlasati = glasanje.MozeGlasati(textBoxOIB.Text);
            string oib = textBoxOIB.Text;
            string opcija = comboBoxOpcija.Text;
            if (mozeGlasati)
            {
                glasanje.Glasaj(oib, opcija);
                OsvjeziRezultate();
            }
            else
                MessageBox.Show("Nemate pravo glasati. Ili niste na biračkom popisu ili ste već glasali!");
        }
    }
}
