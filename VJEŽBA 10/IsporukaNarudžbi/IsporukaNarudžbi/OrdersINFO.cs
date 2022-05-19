using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsporukaNarudžbi
{
    public partial class OrdersINFO : Form
    {
        public OrdersINFO()
        {
            InitializeComponent();
        }

        private void OrdersINFO_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                // POPUNJAVANJE PRVOG COMBO BOX-a
                var query = from orders in context.Orders
                            select orders.ShipCountry;

                countryComboBox.DataSource = query.Distinct().ToList();
                // Distinct() služi da makne duple vrijednosti u ovoj listi u combobox-u
            }
        }

        private void prikaziSveButton_Click(object sender, EventArgs e)
        {
            // PRIKAZ SVIH ORDER-a
            using (var context = new NorthwindEntities())
            {
                // POPUNJAVANJE DATAGRIDVIEW-a
                var query = from orders in context.Orders
                            select orders;

                dataGridView1.DataSource = query.ToList();
                // Moramo sakriti ovu kolonu jer nam zbog nje izbacuje error
                dataGridView1.Columns["Order_Details"].Visible = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Uzimam ORDER iz prvog datagridview-a, te za baš taj order prikazujem order-details u drugom datagridview-u
            Order order = dataGridView1.CurrentRow.DataBoundItem as Order;

            using (var context = new NorthwindEntities())
            {
                var query = from orderDetails in context.Order_Details
                            where orderDetails.OrderID == order.OrderID
                            select orderDetails;

                if(radioButton1.Checked == true)
                {
                    query = from orderDetails in context.Order_Details
                                where orderDetails.OrderID == order.OrderID
                                orderby orderDetails.UnitPrice
                                select orderDetails;
                }


                dataGridView2.DataSource = query.ToList();
                dataGridView2.Columns["Order"].Visible = false;
            }
        }

        private void filtrirajButton_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                var query = from orders in context.Orders
                            where orders.ShipCountry == countryComboBox.SelectedItem.ToString() && orders.ShipCity == cityComboBox.SelectedItem.ToString()
                            select orders;

                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns["Order_Details"].Visible = false;
            }
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // POPUNJAVANJE DRUGOG COMBO BOX-a
            using (var context = new NorthwindEntities())
            {
                var secondQuery = from orders in context.Orders
                                  where orders.ShipCountry == countryComboBox.SelectedItem.ToString()
                                  select orders.ShipCity;


                cityComboBox.DataSource = secondQuery.Distinct().ToList();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Order order = dataGridView1.CurrentRow.DataBoundItem as Order;

            using (var context = new NorthwindEntities())
            {
                var query = from orderDetails in context.Order_Details
                            where orderDetails.OrderID == order.OrderID
                            orderby orderDetails.UnitPrice descending
                            select orderDetails;


                dataGridView2.DataSource = query.ToList();
                dataGridView2.Columns["Order"].Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Order order = dataGridView1.CurrentRow.DataBoundItem as Order;

            using (var context = new NorthwindEntities())
            {
                var query = from orderDetails in context.Order_Details
                            where orderDetails.OrderID == order.OrderID
                            orderby orderDetails.Quantity ascending
                            select orderDetails;


                dataGridView2.DataSource = query.ToList();
                dataGridView2.Columns["Order"].Visible = false;
            }
        }
    }
}
