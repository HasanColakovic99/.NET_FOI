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
    public partial class Form1 : Form
    {
        User user = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Autentificator.LoggedUser = null;
            Autentificator.LogIn(usernameTextBox.Text, passwordTextBox.Text);
            if (Autentificator.LoggedUser == null)
                MessageBox.Show("Unešeni podaci su krivi!");
            else
                MessageBox.Show($"Korisnik {Autentificator.LoggedUser.FirstName} {Autentificator.LoggedUser.LastName} se uspješno prijavio!");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register_From registerForma = new Register_From();
            registerForma.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
