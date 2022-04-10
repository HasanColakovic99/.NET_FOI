using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace Zadatak5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Filter()
        {
            Racun racun = comboBox1.SelectedItem as Racun;
            if (radioButton1.Checked == true)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = racun.DohvatiTransakcije();
            }
            else if (radioButton2.Checked == true)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = racun.DohvatiIsplate();
            }
            else if (radioButton3.Checked == true)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = racun.DohvatiUplate();
            }
        }


        private void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Banka.DohvatiPopisTransakcija();
            Filter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Banka.DohvatiPopisRacuna();
            Osvjezi();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
            Osvjezi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Detalji detalji = new Detalji(comboBox1.SelectedItem as Racun);
            detalji.ShowDialog();
        }
    }
}
