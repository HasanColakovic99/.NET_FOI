using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogometni_susret
{
    public partial class FormGlavna : Form
    {
        public FormGlavna()
        {
            InitializeComponent();
        }

        private void ButtonEvidentiraj_Click(object sender, EventArgs e)
        {
            string oznakaDomacin = textBoxDomacin.Text;
            string oznakaGost = textBoxGost.Text;
            string rezultat = textBoxRezultat.Text;
            KontrolaSusreta ks = new KontrolaSusreta();
            Susret susret = ks.EvidentirajSusret(oznakaDomacin, oznakaGost, rezultat);
            MessageBox.Show($"{susret.reprezentacijaDomacin.Naziv} {susret.brojGolovaDomacin} : {susret.brojGolovaGost} {susret.reprezentacijaGost.Naziv}");
        }
    }
}
