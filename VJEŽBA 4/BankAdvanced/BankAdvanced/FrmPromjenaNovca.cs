using MjenjacnicaLib;
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
    public partial class FrmPromjenaNovca : Form
    {
        public FrmPromjenaNovca()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPromjenaNovca_Load(object sender, EventArgs e)
        {
            cmbIzvorisnaValuta.DataSource = MjenjacnicaDB.Valute.ToList();
            cmbOdredisnaValuta.DataSource = MjenjacnicaDB.Valute.ToList();
            txtIznosIzvorisna.Text = "0";
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            Mjenjacnica mjenjacnica = new Mjenjacnica();
            var izvorisnaValuta = cmbIzvorisnaValuta.SelectedItem as Valuta;
            var odredisnaValuta = cmbOdredisnaValuta.SelectedItem as Valuta;
            double izvorisniIznos = double.Parse(txtIznosIzvorisna.Text);

            double odredisniIznos = mjenjacnica.PromijeniNovac(izvorisnaValuta, odredisnaValuta, izvorisniIznos);

            txtIznosOdredisna.Text = odredisniIznos.ToString();
        }
    }
}
