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
            uiOutputOsobe.DataSource = Osoba.Osobe;
        }
        private Osoba nova = new Osoba();
        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            nova = new Osoba(uiInputIme.Text, uiInputPrezime.Text, uiInputDatumRodenja.Value);
            nova.ToString();
        }

        private void uiActionSvi_Click(object sender, EventArgs e)
        {
            uiOutputOsobe.DataSource = Osoba.Osobe;
        }

        private void uiActionPoDatumu_Click(object sender, EventArgs e)
        {
            //uiOutputOsobe.DataSource = Osoba.OsobeNeDatum(uiInputFilter.Value);
        }

        private void uiOsobe_Load(object sender, EventArgs e)
        {

        }
    }
}