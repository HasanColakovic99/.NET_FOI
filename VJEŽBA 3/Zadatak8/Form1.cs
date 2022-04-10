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

namespace Autentifikacija
{
    public partial class Form1 : Form
    {
        User useri = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Autentificator.LoggedUser = null;
            Autentificator.LogIn(textBox1.Text, passwordTextBox.Text);
            if (textBox1.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Morate unijeti username i password!");
            }
            else if (Autentificator.LoggedUser == null)
            {
                MessageBox.Show("Unijeli ste krive podatke!");
            }
            else if (textBox1.Text != Autentificator.LoggedUser.UserName && passwordTextBox.Text != Autentificator.LoggedUser.Password)
            {
                Autentificator.LoggedUser = null;
            }
            else
            {
                useri.UserName = textBox1.Text;
                useri.Password = passwordTextBox.Text;
                User_profile user = new User_profile(useri);
                this.Hide();
                user.ShowDialog();
            }
        }
    }
}
