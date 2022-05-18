using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinIMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(var context = new NorthwindEntities())
            {
                var query = from suppliers in context.Suppliers
                            select suppliers.CompanyName;

                comboBox1.DataSource = query.ToList();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedSupplier = comboBox1.SelectedItem.ToString();

            using (var context = new NorthwindEntities())
            {
                var query = from products in context.Products
                            where products.Suppliers.CompanyName == selectedSupplier
                            orderby products.ProductName ascending 
                            select products;

                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns["Suppliers"].Visible = false;
            }
        }

        private void pretraziButton_Click(object sender, EventArgs e)
        {

            using (var context = new NorthwindEntities())
            {
                var query = from products in context.Products
                            where products.ProductName == nazivTextBox.Text
                            select products;

                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
