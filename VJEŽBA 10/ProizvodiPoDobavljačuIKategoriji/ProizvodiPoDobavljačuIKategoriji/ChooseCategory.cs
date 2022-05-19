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
    public partial class ChooseCategory : Form
    {
        public string category;
        public ChooseCategory()
        {
            InitializeComponent();
        }

        private void ChooseCategory_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                var query = from category in context.Categories
                            select new
                            {
                                CategoryID = category.CategoryID,
                                CategoryName = category.CategoryName
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            category = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Close();
        }
    }
}
