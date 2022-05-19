using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobavljačiProizvoda
{
    public partial class ChooseSupplier : Form
    {
        public string supplier;
        public ChooseSupplier()
        {
            InitializeComponent();
        }

        private void ChooseSupplier_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                var query = from suppliers in context.Suppliers
                            select suppliers.City;

                comboBox1.DataSource = query.ToList();
            }

            Osvjezi();
        }

        public void Osvjezi()
        {
            using (var context = new NorthwindEntities())
            {
                var query = from suppliers in context.Suppliers
                            where suppliers.City == comboBox1.SelectedValue.ToString()
                            select new
                            {
                                SupplierID = suppliers.SupplierID,
                                CompanyName = suppliers.CompanyName
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            supplier = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
