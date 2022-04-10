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
    public partial class Form1 : Form
    {
        User useri = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autentificator.LoggedUser = null;
            Autentificator.LogIn(textBox1.Text, textBox2.Text);
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Morate unijeti username i šifru!");
            }
            else if(Autentificator.LoggedUser == null)
            {
                MessageBox.Show("Uneseni podaci nisu tačni!");
            }
            else if (Autentificator.LoggedUser.UserName == textBox1.Text && Autentificator.LoggedUser.Password == textBox2.Text)
            {
                useri.UserName = textBox1.Text;
                useri.Password = textBox2.Text;
                User_profile user = new User_profile(useri);
                user.ShowDialog();
            }
        }
    }
}
