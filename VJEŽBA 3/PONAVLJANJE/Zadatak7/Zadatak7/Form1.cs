using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib2;

namespace Zadatak7
{
    public partial class Form1 : Form
    {
        Knjiznica knjiznica = new Knjiznica();
        public Form1()
        {
            InitializeComponent();
        }

        private void SvePosudbe()
        {
            List<Posudba> listaPosudbi = knjiznica.DohvatiSvePosudbe();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPosudbi;
            for (int i = 0; i < listaPosudbi.Count; i++)
            {
                if (listaPosudbi[i].Vraceno == true)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    button1.Enabled = true;
                }
                button1.Enabled = false;
            }

            
        }

        private void TrenutnePosudbe()
        {
            List<Posudba> listaPosudbi = knjiznica.DohvatiTrenutnePosudbe();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPosudbi;
            for (int i = 0; i < listaPosudbi.Count; i++)
            {
                if (listaPosudbi[i].Vraceno == false)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SvePosudbe();
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SvePosudbe();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TrenutnePosudbe();
            button1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            List<Posudba> listaPosudbi = knjiznica.DohvatiProslePosudbe();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPosudbi;
            for (int i = 0; i < listaPosudbi.Count; i++)
            {
                if (listaPosudbi[i].Vraceno == true)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Posudba posudba = dataGridView1.CurrentRow.DataBoundItem as Posudba;
            knjiznica.VratiKnjigu(posudba);
            TrenutnePosudbe();
        }
    }
}
