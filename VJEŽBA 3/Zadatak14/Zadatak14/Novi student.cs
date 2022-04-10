using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentiTimoviLib;

namespace Zadatak14
{
    public partial class Novi_student : Form
    {
        
        public Novi_student()
        {
            InitializeComponent();
        }

        private void Novi_student_Load(object sender, EventArgs e)
        {
            
        }

        private void ureduButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text, textBox2.Text, textBox3.Text);
            KolegijManager.DodajNovogStudenta(student);
            Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
