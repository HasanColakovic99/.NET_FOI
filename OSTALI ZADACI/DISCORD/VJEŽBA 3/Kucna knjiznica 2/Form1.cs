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

namespace Kucna_knjiznica_2
{
    public partial class FormGlavna : Form
    {
        public Knjiznica knjiznice = new Knjiznica();
        public List<Posudba> listaPosudbi = new List<Posudba>();
        public FormGlavna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            listaPosudbi = knjiznice.DohvatiSvePosudbe();
            dataGridViewPosudbe.DataSource = null;
            dataGridViewPosudbe.DataSource = listaPosudbi;
            for(int i = 0; i < listaPosudbi.Count; i++)
            {
                if (listaPosudbi[i].Vraceno == true)
                {
                    dataGridViewPosudbe.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                } else
                {
                    dataGridViewPosudbe.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void radioButtonSvePosudbe_CheckedChanged(object sender, EventArgs e)
        {
            Osvjezi();
            ButtonVratiKnjigu.Enabled = false;
        }

        private void radioButtonTrenutnePosudbe_CheckedChanged(object sender, EventArgs e)
        {
            OsvjeziTrenutne();
            ButtonVratiKnjigu.Enabled = true;
        }

        private void radioButtonProslePosudbe_CheckedChanged(object sender, EventArgs e)
        {
            listaPosudbi = knjiznice.DohvatiProslePosudbe();
            dataGridViewPosudbe.DataSource = null;
            dataGridViewPosudbe.DataSource = listaPosudbi;
            for (int i = 0; i < listaPosudbi.Count; i++)
            {
                dataGridViewPosudbe.Rows[i].DefaultCellStyle.BackColor = Color.Green;
            }
            ButtonVratiKnjigu.Enabled = false;
        }

        private void OsvjeziTrenutne()
        {
            listaPosudbi = knjiznice.DohvatiTrenutnePosudbe();
            dataGridViewPosudbe.DataSource = null;
            dataGridViewPosudbe.DataSource = listaPosudbi;
            for (int i = 0; i < listaPosudbi.Count; i++)
            {
                dataGridViewPosudbe.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void ButtonVratiKnjigu_Click(object sender, EventArgs e)
        {
            Posudba odabranaPosudba = dataGridViewPosudbe.CurrentRow.DataBoundItem as Posudba;
            knjiznice.VratiKnjigu(odabranaPosudba);
            OsvjeziTrenutne();
        }


    }
}
