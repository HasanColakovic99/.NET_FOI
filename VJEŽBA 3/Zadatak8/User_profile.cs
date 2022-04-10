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
    public partial class User_profile : Form
    {
        Form1 forma = new Form1();
        User useri = new User();
        public User_profile(User useri)
        {
            InitializeComponent();
            this.useri = useri;
        }

        private void User_profile_Load(object sender, EventArgs e)
        {
            if(useri.UserName == Autentificator.LoggedUser.UserName && useri.Password == Autentificator.LoggedUser.Password)
            {
                textBox1.Text = Autentificator.LoggedUser.FirstName;
                textBox2.Text = Autentificator.LoggedUser.LastName;
                textBox3.Text = Autentificator.LoggedUser.UserName;
                textBox4.Text = Autentificator.LoggedUser.Password;
            }

            if(useri.UserName == Autentificator.LoggedUser.UserName && useri.Password == Autentificator.LoggedUser.Password)
            {
                if(useri.UserName == "admin" && useri.Password == "admin")
                {
                    radioButton1.Checked = true;
                }
                else if (useri.UserName == "pperic" && useri.Password == "1111")
                {
                    radioButton3.Checked = true;
                }
                else if (useri.UserName == "guest" && useri.Password == "guest")
                {
                    radioButton2.Checked = true;
                }
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Autentificator.LoggedUser = null;
            Autentificator.LogOut();
            Close();
            forma.ShowDialog();
        }
    }
}
