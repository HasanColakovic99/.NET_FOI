using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutentifikacijaLib;

namespace AUTENTIFIKACIJA_ZADATAK_3
{
    public partial class Register_From : Form
    {
        public Register_From()
        {
            InitializeComponent();
        }

        private void Register_From_Load(object sender, EventArgs e)
        {
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = textBox1.Text;
            user.LastName = textBox2.Text;
            user.UserName = textBox3.Text;
            user.Password = textBox4.Text;
            if (radioButton1.Checked)
                user.UserType = UserType.Guest;
            else if (radioButton2.Checked)
                user.UserType = UserType.Guest;
            else if (radioButton3.Checked)
                user.UserType = UserType.Employee;
            Registrator.RegisterUser(user);
            Close();
        }
    }
}
