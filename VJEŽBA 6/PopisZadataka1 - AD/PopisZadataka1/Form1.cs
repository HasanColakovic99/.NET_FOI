using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopisZadataka1
{
    public partial class Form1 : Form
    {
        RepozitorijZadataka repozitorij = new RepozitorijZadataka();
        public Form1()
        {
            InitializeComponent();
        }

        public void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repozitorij.Zadaci;

            for(int i = 0; i < repozitorij.Zadaci.Count; i++)
            {
                Zadatak zadatak = dataGridView1.Rows[i].DataBoundItem as Zadatak;
                if(zadatak.Rok.Day < DateTime.Now.Day+1)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repozitorij.Zadaci.Add(new Zadatak(textBox1.Text, dateTimePicker1.Value));
            repozitorij.Zadaci.Sort((x,y) => x.Rok.CompareTo(y.Rok));
            Osvjezi();
        }
    }
}
