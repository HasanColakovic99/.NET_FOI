using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanovniciHrvatske
{
    public partial class DodavanjeZaposlenika : Form
    {
        public DodavanjeZaposlenika()
        {
            InitializeComponent();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajStanovnikaButton_Click(object sender, EventArgs e)
        {
            using(var context = new LabsEntities())
            {
                string ime = imeTextBox.Text;
                string prezime = prezimeTextBox.Text;
                string oib = oibTextBox.Text;
                string jmbag = jmbagTextBox.Text;

                Stanovnici stanovnik = new Stanovnici()
                {
                    Ime = ime,
                    Prezime = prezime,
                    OIB = oib,
                    JMBG = jmbag
                };

                context.Stanovnicis.Add(stanovnik);
                context.SaveChanges();
            }
            Close();
        }
    }
}
