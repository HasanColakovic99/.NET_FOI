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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            ChooseSupplier supplier = new ChooseSupplier();
            supplier.ShowDialog();
            supplierTextBox.Text = supplier.supplier;
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            ChooseCategory category = new ChooseCategory();
            category.ShowDialog();
            categoryTextBox.Text = category.category;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void displayProductsButton_Click(object sender, EventArgs e)
        {
            int category = int.Parse(categoryTextBox.Text);
            int supplier = int.Parse(supplierTextBox.Text);

            using (var context = new NorthwindEntities())
            {
                var query = from products in context.Products
                            from suppliers in context.Suppliers
                            from categories in context.Categories
                            where products.CategoryID == category && products.SupplierID == supplier && suppliers.SupplierID == supplier && categories.CategoryID == category
                            select new
                            {
                                products.ProductID,
                                products.ProductName,
                                categories.CategoryName,
                                suppliers.CompanyName
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
