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
    public partial class OdaberiKlijentaForm : Form
    {
        public IKlijent OdabraniKlijent { get; set; }

        public OdaberiKlijentaForm()
        {
            InitializeComponent();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            OdabraniKlijent = null;
            Close();
        }

        private void odaberiButton_Click(object sender, EventArgs e)
        {
            OdabraniKlijent = DohvatiSelektiranogKlijenta();
            Close();
        }

        private IKlijent DohvatiSelektiranogKlijenta()
        {
            if (klijentiDataGridView.CurrentRow != null)
            {
                return klijentiDataGridView.CurrentRow.DataBoundItem as IKlijent;
            }
            return null;
        }

        private void OdaberiKlijentaForm_Load(object sender, EventArgs e)
        {
            klijentiDataGridView.DataSource = Repozitorij.DohvatiKlijente().ToList();
        }
    }
}
