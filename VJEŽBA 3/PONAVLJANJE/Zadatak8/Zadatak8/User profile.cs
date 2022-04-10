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

namespace Zadatak8
{
    public partial class User_profile : Form
    {
        User user = new User();
        public User_profile(User useri)
        {
            InitializeComponent();
            this.user = useri;
        }

        private void User_profile_Load(object sender, EventArgs e)
        {
            if(Autentificator.LoggedUser.UserName == user.UserName && Autentificator.LoggedUser.Password == user.Password)
            {
                textBox1.Text = Autentificator.LoggedUser.FirstName;
                textBox2.Text = Autentificator.LoggedUser.LastName;
                textBox3.Text = Autentificator.LoggedUser.UserName;
                textBox4.Text = Autentificator.LoggedUser.Password;

                if (Autentificator.LoggedUser.UserType == UserType.Administrator)
                {
                    radioButton1.Checked = true;
                }
                else if (Autentificator.LoggedUser.UserType == UserType.Guest)
                {
                    radioButton2.Checked = true;
                }
                else if (Autentificator.LoggedUser.UserType == UserType.Employee)
                {
                    radioButton3.Checked = true;
                }
            }
        }
    }
}
