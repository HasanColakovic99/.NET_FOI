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

namespace AdministriranjeKorisnika
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Autentificator.LoggedUser = null;
            Autentificator.LogIn(textBoxUsername.Text, textBoxPassword.Text);
            if (Autentificator.LoggedUser == null)
            {
                MessageBox.Show("Entered credentials are not valid.");
                return;
            }
            else if (textBoxUsername.Text != "admin" && textBoxPassword.Text != "admin")
            {
                MessageBox.Show("You must be administrator to log in");
                Autentificator.LoggedUser = null;
                return;
            }
            var form = new FormUserList();
            form.ShowDialog();
        }
    }
}
