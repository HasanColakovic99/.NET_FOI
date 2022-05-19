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
    public partial class DodajAdresu : Form
    {
        Stanovnici Stanovnik = new Stanovnici();
        public DodajAdresu(Stanovnici stanovnik)
        {
            InitializeComponent();
            Stanovnik = stanovnik;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajAdresuButton_Click(object sender, EventArgs e)
        {
            using(var context = new LabsEntities())
            {
                int idMjesta = int.Parse(idMjestaTextBox.Text);
                string adresa = adresaTextBox.Text;
                DateTime datum = dateTimePicker.Value.Date;

                Adrese adrese = new Adrese()
                {
                    IDStanovnika = Stanovnik.ID,
                    IDMjesta = idMjesta,
                    Adresa = adresa,
                    AktivnaDo = datum
                };

                context.Adrese.Attach(adrese);
                context.Adrese.Add(adrese);
                context.SaveChanges();
            }
            MessageBox.Show("Uspješno ste dodali adresu!");
            Close();
        }
    }
}
