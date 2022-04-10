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
    public partial class TransakcijeForm : Form
    {
        public TransakcijeForm()
        {
            InitializeComponent();
        }

        private void TransakcijeForm_Load(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }

        private void zatvoriButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OsvjeziPrikaz()
        {
            transakcijeDataGridView.DataSource = Repozitorij.DohvatiTransakcije().ToList();
        }
    }
}
