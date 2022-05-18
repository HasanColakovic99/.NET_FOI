using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZemljaDobavljača
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Osvjezi()
        {
            using (var context = new NorthwindEntities())
            {
                var query = from suppliers in context.Suppliers
                            select suppliers;

                var secondQuery = from countries in context.Suppliers
                                  select countries.Country;

                dataGridView1.DataSource = query.ToList();
                comboBox1.DataSource = secondQuery.Distinct().ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            using(var context = new NorthwindEntities())
            {
                var query = from suppliers in context.Suppliers
                            where suppliers.CompanyName.Contains(companyNameTextBox.Text)
                            select suppliers;

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string country = comboBox1.SelectedItem.ToString();

            using (var context = new NorthwindEntities())
            {
                var query = from suppliers in context.Suppliers
                            where suppliers.Country == country
                            select suppliers;

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }
    }
}
