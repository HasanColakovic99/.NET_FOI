using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registracija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrator registrator = new Registrator();
            if(registrator.Registriraj(textBox1.Text, textBox2.Text) == true)
            {
                MessageBox.Show("Uspješno dodan korisnik!");
            }
            else
            {
                MessageBox.Show("Taj korisnik već postoji!");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
