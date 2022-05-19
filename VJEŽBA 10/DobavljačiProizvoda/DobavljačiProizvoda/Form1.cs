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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            ChooseSupplier supplier = new ChooseSupplier();
            supplier.ShowDialog();
            supplierTextBox.Text = supplier.supplier;
        }

        private void displayProductsButton_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                var query = from products in context.Products
                            where supplierTextBox.Text == products.Supplier.CompanyName
                            select new
                            {
                                ProductID = products.ProductID,
                                ProductName = products.ProductName,
                                CompanyName = supplierTextBox.Text,
                                CategoryName = products.Category.CategoryName
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
