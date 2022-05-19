using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProizvodiPoDobavljačuIKategoriji
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
                            select new 
                            {
                                SupplierID = suppliers.SupplierID,
                                CompanyName = suppliers.CompanyName,
                                Country = suppliers.Country,
                                City = suppliers.City
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            supplier = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Close();
        }
    }
}
