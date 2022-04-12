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

namespace Registracija_i_prijava
{
    public partial class FormGlavna : Form
    {
        public FormGlavna()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            FormRegister novaForma = new FormRegister();
            novaForma.ShowDialog();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            Autentificator.LoggedUser = null;
            Autentificator.LogIn(textBoxUsername.Text, textBoxPassword.Text);
            if(Autentificator.LoggedUser == null)
                MessageBox.Show("Entered credentials are not valid!");
            else
                MessageBox.Show($"User {Autentificator.LoggedUser.FirstName} {Autentificator.LoggedUser.LastName} is successfuly Logged in");
        }
    }
}
