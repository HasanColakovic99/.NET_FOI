using BankaLib;
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
    public partial class OdaberiValutuForm : Form
    {
        public Valuta OdabranaValuta { get; set; }
        public OdaberiValutuForm()
        {
            InitializeComponent();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            OdabranaValuta = null;
            Close();
        }

        private void OdaberiValutuForm_Load(object sender, EventArgs e)
        {
            valuteDataGridView.DataSource = Repozitorij.DohvatiValute();
        }

        private void odaberiButton_Click(object sender, EventArgs e)
        {
            OdabranaValuta = DohvatiOdabranuValutu();
            Close();
        }

        private Valuta DohvatiOdabranuValutu()
        {
            if (valuteDataGridView.CurrentRow != null)
            {
                return valuteDataGridView.CurrentRow.DataBoundItem as Valuta;
            }
            return null;
        }
    }
}
