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

namespace Zadatak1
{
    public partial class LogInForma : Form
    {
        public LogInForma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Autentificator.LoggedUser = null;
            Autentificator.LogIn(usernameTextBox.Text, passwordTextBox.Text);
            if (Autentificator.LoggedUser == null)
            {
                MessageBox.Show("Entered credentials are not valid.");
                return;
            }
            else if (usernameTextBox.Text != "admin" && passwordTextBox.Text != "admin")
            {
                MessageBox.Show("You must be administrator to log in");
                Autentificator.LoggedUser = null;
                return;
            } 
            else
            {
                PopisUsera popis = new PopisUsera();
                popis.ShowDialog();
            }
        }
    }
}
