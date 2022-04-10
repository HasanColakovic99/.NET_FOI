using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace BankAdvanced
{
    public partial class KlijentiForm : Form
    {
        public KlijentiForm()
        {
            InitializeComponent();
        }

        private void KlijentiForm_Load(object sender, EventArgs e)
        {
            OsvjeziKlijente();
        }

        private void OsvjeziKlijente()
        {
            klijentiDataGridView.DataSource = Repozitorij.DohvatiKlijente().ToList();
        }

        private void detaljiButton_Click(object sender, EventArgs e)
        {
            IKlijent klijent = DohvatiKlijenta();
            DetaljiKlijentaForm form = new DetaljiKlijentaForm(klijent);
            form.ShowDialog();

            OsvjeziKlijente();
        }

        private IKlijent DohvatiKlijenta()
        {
            int selectedPosition = klijentiDataGridView.CurrentRow.Index;
            DataGridViewRow selectedRow = klijentiDataGridView.Rows[selectedPosition];

            return selectedRow.DataBoundItem as IKlijent;
        }
    }
}
