using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AzurirajAdresu : Form
    {
        Adrese Adresa;
        Stanovnici Stanovnik;
        public AzurirajAdresu(Adrese adresa, Stanovnici stanovnik)
        {
            InitializeComponent();
            Adresa = adresa;
            Stanovnik = stanovnik;
        }

        private void AzurirajAdresu_Load(object sender, EventArgs e)
        {
            idMjestaTextBox.Text = Adresa.IDMjesta.ToString();
            adresaTextBox.Text = Adresa.Adresa;
            dateTimePicker.Text = Adresa.AktivnaDo.Value.ToString();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void azurirajAdresuButton_Click(object sender, EventArgs e)
        {
            using(var context = new LabsEntities())
            {
                int id = int.Parse(idMjestaTextBox.Text);
                string adresa = adresaTextBox.Text;
                DateTime datum = dateTimePicker.Value.Date;

                context.Adrese.Attach(Adresa);

                Adresa.IDMjesta = id;
                Adresa.Adresa = adresa;
                Adresa.AktivnaDo = datum;

                context.SaveChanges();
            }
            MessageBox.Show("Uspješno ste ažurirali adresu!");
            Close();
        }
    }
}
