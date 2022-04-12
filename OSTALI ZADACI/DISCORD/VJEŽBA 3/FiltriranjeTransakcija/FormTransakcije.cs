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

namespace FiltriranjeTransakcija
{
    public partial class FormTransakcije : Form
    {
        public Racun BankovniRacun { get; set; }
        public List<Racun> PopisRacuna { get; set; }
        public FormTransakcije()
        {
            BankovniRacun = new Racun();
            PopisRacuna = new List<Racun>();
            InitializeComponent();
            radioButtonSve.Checked = true;
        }

        private void FormTransakcije_Load(object sender, EventArgs e)
        {
            PopisRacuna = Banka.DohvatiPopisRacuna();
            comboBoxRacun.DataSource = PopisRacuna;
            IspisiTransakcije();
            
        }

        private void IspisiTransakcije()
        {
            this.BankovniRacun = this.PopisRacuna.FirstOrDefault(racun => racun.IBAN == comboBoxRacun.SelectedItem.ToString());
            dataGridViewTransakcije.DataSource = this.BankovniRacun.DohvatiTransakcije();
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
            if (radioButtonSve.Checked)
            {
                IspisiTransakcije();
            }
            else if (radioButtonIsplate.Checked)
            {
                this.BankovniRacun = this.PopisRacuna.FirstOrDefault(racun => racun.IBAN == comboBoxRacun.SelectedItem.ToString());
                dataGridViewTransakcije.DataSource = this.BankovniRacun.DohvatiIsplate();
            }
            else if (radioButtonUplate.Checked)
            {
                this.BankovniRacun = this.PopisRacuna.FirstOrDefault(racun => racun.IBAN == comboBoxRacun.SelectedItem.ToString());
                dataGridViewTransakcije.DataSource = this.BankovniRacun.DohvatiUplate();
            }
        }

        private void buttonOcisti_Click(object sender, EventArgs e)
        {
            comboBoxRacun.SelectedIndex = 0;
            radioButtonSve.Checked = true;
            radioButtonIsplate.Checked = false;
            radioButtonUplate.Checked = false;
            IspisiTransakcije();
        }

        private void buttonDetaljiRacuna_Click(object sender, EventArgs e)
        {
            var form = new FormDetalji(BankovniRacun);
            form.ShowDialog();
        }

        private void comboBoxRacun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
