using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitulaZaposlenika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Osvjezi()
        {
            using(var context = new NorthwindEntities())
            {
                var query = from employees in context.Employees
                            orderby employees.LastName ascending
                            select employees;

                var secondQuery = from employees in context.Employees
                                  select employees.Title;

                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns["Employees1"].Visible = false;
                dataGridView1.Columns["Employees2"].Visible = false;

                comboBox1.DataSource = secondQuery.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string title = comboBox1.SelectedItem.ToString();

            using(var context = new NorthwindEntities())
            {
                var query = from employees in context.Employees
                            where employees.Title == title
                            select new
                            {
                                FirstName = employees.FirstName,
                                LastName = employees.LastName,
                                Title = employees.Title,
                                City = employees.City,
                                Country = employees.Country
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using(var context = new NorthwindEntities())
            {
                var query = from employees in context.Employees
                            where employees.FirstName == firstLastNameTextBox.Text || employees.LastName == firstLastNameTextBox.Text
                            select employees;

                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
