using BankaLib;
using BankaLib.Iznimke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAdvanced
{
    public partial class NovaTransakcijaForm : Form
    {
        private IKlijent _klijentPlatitelj;
        private IRacun _racunPlatitelj;

        private IKlijent _klijentPrimatelj;
        private IRacun _racunPrimatelj;

        public NovaTransakcijaForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void racunPlatiteljButton_Click(object sender, EventArgs e)
        {
            if (_klijentPlatitelj != null)
            {
                OdaberiRacunForm form = new OdaberiRacunForm(_klijentPlatitelj);
                form.ShowDialog();

                _racunPlatitelj = form.OdabraniRacun;
                PrikaziRacunPlatitelj();
            }
            else
            {
                MessageBox.Show("Prvo morate odabrati klijenta!");
            }
        }

        private void PrikaziRacunPlatitelj()
        {
            if (_racunPlatitelj != null)
            {
                racunPlatiteljTextBox.Text = _racunPlatitelj.Opis;
            }
            else
            {
                racunPlatiteljTextBox.Text = "";
            }
        }

        private void racunPrimateljButton_Click(object sender, EventArgs e)
        {
            if (_klijentPrimatelj != null)
            {
                OdaberiRacunForm form = new OdaberiRacunForm(_klijentPrimatelj);
                form.ShowDialog();

                _racunPrimatelj = form.OdabraniRacun;
                PrikaziRacunPrimatelj();
            }
            else
            {
                MessageBox.Show("Prvo morate odabrati klijenta!");
            }
        }

        private void PrikaziRacunPrimatelj()
        {
            if (_racunPrimatelj != null)
            {
                racunPrimateljTextBox.Text = _racunPrimatelj.Opis;
            }
            else
            {
                racunPrimateljTextBox.Text = "";
            }
        }

        private void klijentPlatiteljButton_Click(object sender, EventArgs e)
        {
            OdaberiKlijentaForm form = new OdaberiKlijentaForm();
            form.ShowDialog();

            _klijentPlatitelj = form.OdabraniKlijent;
            PrikaziKlijentaPlatitelja();
        }

        private void PrikaziKlijentaPlatitelja()
        {
            if (_klijentPlatitelj != null)
            {
                klijentPlatiteljTextBox.Text = _klijentPlatitelj.Opis;
            }
            else
            {
                klijentPlatiteljTextBox.Text = "";
            }
        }

        private void klijentPrimateljButton_Click(object sender, EventArgs e)
        {
            OdaberiKlijentaForm form = new OdaberiKlijentaForm();
            form.ShowDialog();

            _klijentPrimatelj = form.OdabraniKlijent;
            PrikaziKlijentaPrimatelja();
        }

        private void PrikaziKlijentaPrimatelja()
        {
            if (_klijentPrimatelj != null)
            {
                klijentPrimateljTextBox.Text = _klijentPrimatelj.Opis;
            }
            else
            {
                klijentPrimateljTextBox.Text = "";
            }
        }

        private void provediButton_Click(object sender, EventArgs e)
        {
            double iznos = double.Parse(iznosTextBox.Text);
            Banka.ProvediTransakciju(_racunPlatitelj, _racunPrimatelj, iznos);
            Close();
        }
    }
}
