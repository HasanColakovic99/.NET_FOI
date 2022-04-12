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

namespace PrijavaPrikazKorisnickogProfila
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Autentificator.LogIn(textBoxUsername.Text, textBoxPassword.Text);
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Username and password must be entered.");
            }
            else if (Autentificator.LoggedUser == null)
            {
                MessageBox.Show("Entered credentials are not valid!");
            }
            else
            {
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                var form = new FormUserProfile();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
