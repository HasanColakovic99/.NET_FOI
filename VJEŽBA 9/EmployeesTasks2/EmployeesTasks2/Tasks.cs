using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesTasks2
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        public void Osvjezi()
        {
            employeesDataGridView.DataSource = DohvatiZaposlenike();
            employeesDataGridView.Columns["Tasks"].Visible = false;
        }

        public object DohvatiZaposlenike()
        {
            using(var context = new EF_DBEntities())
            {
                return context.Employees.ToList();
            }
        }

        public Employee DohvatiZaposlenika()
        {
            return employeesDataGridView.CurrentRow.DataBoundItem as Employee;
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            using(var context = new EF_DBEntities())
            {
                string ime = firstNameTextBox.Text;
                string prezime = lastNameTextBox.Text;

                Employee zaposlenik = new Employee()
                {
                    FirstName = ime,
                    LastName = prezime
                };

                context.Employees.Add(zaposlenik);
                context.SaveChanges();
            }
            Osvjezi();
        }

        public void DohvatiZadatke()
        {
            Employee employee = DohvatiZaposlenika();
            using (var context = new EF_DBEntities())
            {
                context.Employees.Attach(employee);
                tasksDataGridView.DataSource = employee.Tasks.OrderBy(x => x.Description).ToList();
            }
        }

        private void employeesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DohvatiZadatke();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            Employee employee = DohvatiZaposlenika();
            using (var context = new EF_DBEntities())
            {
                string description = descriptionTextBox.Text;
                int priority = int.Parse(comboBox1.SelectedItem.ToString());


                Task noviZadatak = new Task()
                {
                    Description = description,
                    Priority = priority,
                    EmployeeId = employee.Id,
                    Completed = false,
                    Employee = employee
                };
                
                context.Tasks.Add(noviZadatak);
                context.SaveChanges();
            }
            DohvatiZadatke();
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            Task zadatak = tasksDataGridView.CurrentRow.DataBoundItem as Task;
            using (var context = new EF_DBEntities())
            {
                context.Tasks.Attach(zadatak);
                context.Tasks.Remove(zadatak);
                context.SaveChanges();
            }
            DohvatiZadatke();
        }
    }
}
