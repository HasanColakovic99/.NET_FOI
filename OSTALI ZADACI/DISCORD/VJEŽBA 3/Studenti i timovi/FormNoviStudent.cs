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

namespace Studenti_i_timovi
{
    public partial class FormNoviStudent : Form
    {
        public FormNoviStudent()
        {
            InitializeComponent();
        }

        private void ButtonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonURedu_Click(object sender, EventArgs e)
        {
            Student noviStudent = new Student(textBoxJMBAG.Text, textBoxIme.Text, textBoxPrezime.Text);
            KolegijManager.DodajNovogStudenta(noviStudent);
            Close();
        }
    }
}
