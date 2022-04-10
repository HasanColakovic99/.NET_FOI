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
    public partial class Administrators_Start_Form : Form
    {
        public Administrators_Start_Form()
        {
            InitializeComponent();
        }

        private void Buttoni()
        {

        }


        private void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = UsersRepository.GetUsers();
        }

        private void Administrators_Start_Form_Load(object sender, EventArgs e)
        {
            Osvjezi();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            User korisnik = dataGridView1.CurrentRow.DataBoundItem as User;
            if (korisnik.Status == UserStatus.Deactivated)
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
            else if (korisnik.Status == UserStatus.Activated)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User korisnik = dataGridView1.CurrentRow.DataBoundItem as User;
            if(korisnik.Status == UserStatus.Deactivated)
            {
                korisnik.Status = UserStatus.Activated;
            }
            Osvjezi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User korisnik = dataGridView1.CurrentRow.DataBoundItem as User;
            if (korisnik.Status == UserStatus.Activated)
            {
                korisnik.Status = UserStatus.Deactivated;
            }
            Osvjezi();
        }
    }
}
