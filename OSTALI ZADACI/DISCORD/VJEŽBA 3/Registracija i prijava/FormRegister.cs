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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            User registracija = new User();
            registracija.FirstName = textBoxFirstname.Text;
            registracija.LastName = textBoxLastname.Text;
            registracija.UserName = textBoxUsername.Text;
            registracija.Password = textBoxPassword.Text;
            if (radioButtonAdministrator.Checked)
                registracija.UserType = UserType.Administrator;
            else if (radioButtonEmployee.Checked)
                registracija.UserType = UserType.Employee;
            else
                registracija.UserType = UserType.Guest;
            Registrator.RegisterUser(registracija);
            Close();
        }
    }
}
