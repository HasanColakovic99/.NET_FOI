using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osobe
{
    public partial class uiOsobe : Form
    {
        
        public uiOsobe()
        {
            InitializeComponent();
            uiOutputOsobe.DataSource = Osoba.sveOsobe;
        }
        public Osoba nova =  new Osoba();
        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                nova.Ime = uiInputIme.Text;
                nova.Prezime = uiInputPrezime.Text;
                nova.DatumRodenja = uiInputDatumRodenja.Value;
                Osoba.sveOsobe.Add(new Osoba(uiInputIme.Text, uiInputPrezime.Text, uiInputDatumRodenja.Value));
            }
            catch (DateException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void uiActionSvi_Click(object sender, EventArgs e)
        {
            uiOutputOsobe.DataSource = Osoba.sveOsobe;
        }

        private void uiActionPoDatumu_Click(object sender, EventArgs e)
        {
            //uiOutputOsobe.DataSource = Osoba.OsobeNeDatum(uiInputFilter.Value);
        }
    }
}