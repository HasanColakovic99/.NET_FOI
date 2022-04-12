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
    public partial class FormUserProfile : Form
    {
        public FormUserProfile()
        {
            InitializeComponent();
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            textBoxFirstname.Text = Autentificator.LoggedUser.FirstName;
            textBoxLastname.Text = Autentificator.LoggedUser.LastName;
            textBoxUser.Text = Autentificator.LoggedUser.UserName;
            textBoxPass.Text = Autentificator.LoggedUser.Password;
            if (Autentificator.LoggedUser.UserType == UserType.Administrator)
            {
                radioButtonAdministrator.Checked = true;
            }
            else if (Autentificator.LoggedUser.UserType == UserType.Employee)
            {
                radioButtonEmployee.Checked = true;
            }
            else if (Autentificator.LoggedUser.UserType == UserType.Guest)
            {
                radioButtonGuest.Checked = true;
            }

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Autentificator.LogOut();
            Close();
        }
    }
}
