using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadatak10;

namespace GlavnaForma
{
    public partial class Form1 : Form
    {
        public List<IPretraga> Knjiznica = new List<IPretraga>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void DodajAutore(Knjiga knjiga, Autor autor)
        {
            knjiga.DodajAutora(autor);
        }

        public void UkloniAutora(Knjiga knjiga, Autor autor)
        {
            knjiga.UkloniAutora(autor);
        }

        public void Pretrazi(string kljucnaRijec)
        {
            Knjiga knjiga = new Knjiga();
            knjiga.Usporedi(kljucnaRijec);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
