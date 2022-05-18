using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijevozniciIKupci
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
                var query = from shippers in context.Shippers
                            select shippers.CompanyName;
                var secondQuery = from customers in context.Customers
                                  select customers.CompanyName;

                shipperComboBox.DataSource = query.ToList();
                customerComboBox.DataSource = secondQuery.ToList();
            }
        }

        public void Osvjezi()
        {
            using(var context = new NorthwindEntities())
            {
                var query = from orders in context.Orders
                            select orders;
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns["Customer"].Visible = false;
                dataGridView1.Columns["Order_Details"].Visible = false;
                dataGridView1.Columns["Shipper"].Visible = false;
            }
        }
        private void prikaziSveButton_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Order selectedOrder = dataGridView1.CurrentRow.DataBoundItem as Order;

            using(var context = new NorthwindEntities())
            {
                var query = from ordersDetails in context.Order_Details
                            where ordersDetails.OrderID == selectedOrder.OrderID
                            select ordersDetails;
                
                dataGridView2.DataSource = query.ToList();
                dataGridView2.Columns["Order"].Visible = false;
            }
        }

        private void filtrirajButton_Click(object sender, EventArgs e)
        {
            string shipper = shipperComboBox.SelectedItem.ToString();
            string customer = customerComboBox.SelectedItem.ToString();

            using (var context = new NorthwindEntities())
            {
                var query = from orders in context.Orders
                            where orders.Shipper.CompanyName == shipper && orders.Customer.CompanyName == customer
                            select orders;

                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
