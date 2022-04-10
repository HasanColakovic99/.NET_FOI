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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autentificator.LoggedUser = null;
            Autentificator.LogIn(textBox1.Text, textBox2.Text);
            
            if(Autentificator.LoggedUser == null)
            {
                MessageBox.Show("Unijeli ste krive podatke!");
            }
            else if(Autentificator.LoggedUser.UserName != "admin" && Autentificator.LoggedUser.Password != "admin")
            {
                MessageBox.Show("Morate biti administrator da biste se logirali!");
                Autentificator.LoggedUser = null;
            }
            else
            {
                Administrators_Start_Form novaForma = new Administrators_Start_Form();
                this.Hide();
                novaForma.ShowDialog();
            }
        }
    }
}
