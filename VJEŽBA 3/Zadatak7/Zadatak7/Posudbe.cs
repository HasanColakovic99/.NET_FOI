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
    public partial class Posudbe : Form
    {
        Knjiznica knjiznica = new Knjiznica();
        public Posudbe()
        {
            InitializeComponent();
        }

        private void SvePosudbe()
        {
            List<Posudba> listaPosudbi = knjiznica.DohvatiSvePosudbe();
            posudbeDataGridView.DataSource = null;
            posudbeDataGridView.DataSource = listaPosudbi;
            for(int i = 0; i < listaPosudbi.Count; i++)
            {
                if(listaPosudbi[i].Vraceno == true)
                {
                    posudbeDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    posudbeDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }


        private void TrenutnePosudbe()
        {
            List<Posudba> listaPosudbi = knjiznica.DohvatiTrenutnePosudbe();
            posudbeDataGridView.DataSource = null;
            posudbeDataGridView.DataSource = listaPosudbi;
            for (int i = 0; i < listaPosudbi.Count; i++)
            {
                posudbeDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }


        private void ProslePosudbe()
        {
            List<Posudba> listaPosudbi = knjiznica.DohvatiProslePosudbe();
            posudbeDataGridView.DataSource = null;
            posudbeDataGridView.DataSource = listaPosudbi;
            for (int i = 0; i < listaPosudbi.Count; i++)
            {
                posudbeDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void Posudbe_Load(object sender, EventArgs e)
        {
            SvePosudbe();
            button.Enabled = false;
        }


        private void sveButton_CheckedChanged(object sender, EventArgs e)
        {
            SvePosudbe();
        }

        private void trenutnePosudbeButton_CheckedChanged(object sender, EventArgs e)
        {
            TrenutnePosudbe();
            button.Enabled = true;
        }

        private void proslePosudbeButton_CheckedChanged(object sender, EventArgs e)
        {
            ProslePosudbe();
            button.Enabled = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Posudba posudba = posudbeDataGridView.CurrentRow.DataBoundItem as Posudba;
            knjiznica.VratiKnjigu(posudba);
            TrenutnePosudbe();
        }
    }
}
