using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomašev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Territory odabraniTeritorij = dataGridView1.CurrentRow.DataBoundItem as Territory;

            using (var context = new NorthwindEntities())
            {
                var query = from zaposlenici in context.Employees.Include("Territories")
                            select zaposlenici;

                int ukupanBrojGodina = 0;
                int trenutnaGodina = 0;
                int brojac = 0;
                List<Employee> listaZaposlenika = new List<Employee>();

                foreach (var zapis in query)
                {
                    foreach (var teritorij in zapis.Territories)
                    {
                        if (teritorij.TerritoryID == odabraniTeritorij.TerritoryID)
                        {
                            listaZaposlenika.Add(zapis);

                            brojac++;
                            ukupanBrojGodina += zapis.BirthDate.Value.Year;
                            trenutnaGodina += DateTime.Now.Year;
                            MessageBox.Show("Prosječna starost iznosi: " + (trenutnaGodina - ukupanBrojGodina)/brojac + " godina.");
                        }
                    }
                }



                dataGridView2.DataSource = listaZaposlenika.ToList();
                dataGridView2.Columns["Territories"].Visible = false;
                dataGridView2.Columns["Employee1"].Visible = false;
                dataGridView2.Columns["Employees1"].Visible = false;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                var query = from territories in context.Territories
                            select territories;

                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns["Employees"].Visible = false;
            }
        }

        private void teritorijRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Territory odabraniTeritorij = dataGridView1.CurrentRow.DataBoundItem as Territory;

            using (var context = new NorthwindEntities())
            {
                var query = from zaposlenici in context.Employees.Include("Territories")
                            orderby zaposlenici.Territories ascending
                            select zaposlenici;


                List<Employee> listaZaposlenika = new List<Employee>();

                foreach (var zapis in query)
                {
                    foreach (var teritorij in zapis.Territories)
                    {
                        if (teritorij.TerritoryID == odabraniTeritorij.TerritoryID)
                        {
                            listaZaposlenika.Add(zapis);
                        }
                    }
                }

                dataGridView2.DataSource = listaZaposlenika.ToList();
                dataGridView2.Columns["Territories"].Visible = false;
                dataGridView2.Columns["Employee1"].Visible = false;
                dataGridView2.Columns["Employees1"].Visible = false;
            }
        }

        private void drzavaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Territory odabraniTeritorij = dataGridView1.CurrentRow.DataBoundItem as Territory;

            using (var context = new NorthwindEntities())
            {
                var query = from zaposlenici in context.Employees.Include("Territories")
                            orderby zaposlenici.Country ascending
                            select zaposlenici;


                List<Employee> listaZaposlenika = new List<Employee>();

                foreach (var zapis in query)
                {
                    foreach (var teritorij in zapis.Territories)
                    {
                        if (teritorij.TerritoryID == odabraniTeritorij.TerritoryID)
                        {
                            listaZaposlenika.Add(zapis);
                        }
                    }
                }

                dataGridView2.DataSource = listaZaposlenika.ToList();
                dataGridView2.Columns["Territories"].Visible = false;
                dataGridView2.Columns["Employee1"].Visible = false;
                dataGridView2.Columns["Employees1"].Visible = false;
            }
        }

        private void filtrirajButton_Click(object sender, EventArgs e)
        {
            Territory odabraniTeritorij = dataGridView1.CurrentRow.DataBoundItem as Territory;

            using (var context = new NorthwindEntities())
            {
                var query = from zaposlenici in context.Employees.Include("Territories")
                            where zaposlenici.Country == textBox1.Text
                            select zaposlenici;


                List<Employee> listaZaposlenika = new List<Employee>();

                foreach (var zapis in query)
                {
                    foreach (var teritorij in zapis.Territories)
                    {
                        if (teritorij.TerritoryID == odabraniTeritorij.TerritoryID)
                        {
                            listaZaposlenika.Add(zapis);
                        }
                    }
                }

                dataGridView2.DataSource = listaZaposlenika.ToList();
                dataGridView2.Columns["Territories"].Visible = false;
                dataGridView2.Columns["Employee1"].Visible = false;
                dataGridView2.Columns["Employees1"].Visible = false;
            }
        }
    }
}
