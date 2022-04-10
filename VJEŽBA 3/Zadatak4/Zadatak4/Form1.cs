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


namespace Zadatak4
{
    public partial class Form1 : Form
    {
        List<Transakcija> transakcije = new List<Transakcija>();
        Racun racuni = new Racun();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Racun> racuni = Banka.DohvatiPopisRacuna();
            comboBox.DataSource = racuni;
            
            transakcije = Banka.DohvatiPopisTransakcija();
            popisRacunaDataGridView.DataSource = null;
            popisRacunaDataGridView.DataSource = transakcije;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Transakcija> noveTransakcije = new List<Transakcija>();
            foreach(Transakcija item in transakcije)
            {
                if ((item.Platitelj == comboBox.SelectedItem || item.Primatelj == comboBox.SelectedItem) && sveButton.Checked == true)
                {
                    noveTransakcije.Add(item);
                }
                else if (item.Platitelj == comboBox.SelectedItem && isplateButton.Checked == true)
                {
                    noveTransakcije.Add(item);
                }
                else if(item.Primatelj == comboBox.SelectedItem && uplateButton.Checked == true)
                {
                    noveTransakcije.Add(item);
                }
            }
            popisRacunaDataGridView.DataSource = noveTransakcije;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
            sveButton.Checked = true;
            popisRacunaDataGridView.DataSource = transakcije;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transakcija transakcija = new Transakcija();
            transakcija = popisRacunaDataGridView.CurrentRow.DataBoundItem as Transakcija;
            this.Hide();
            Detalji detalji = new Detalji(transakcija);
            detalji.Show();
        }
    }
}
