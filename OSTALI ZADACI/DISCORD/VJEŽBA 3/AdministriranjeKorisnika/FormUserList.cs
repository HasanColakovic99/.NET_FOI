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
    public partial class FormUserList : Form
    {
        public FormUserList()
        {
            InitializeComponent();
        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
            UcitajKorisnike();
            dataGridViewUsers.SelectionChanged += PromjenaOdabira;
        }

        private void PromjenaOdabira(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow.Cells[5].Value.ToString() == "Activated")
            {
                buttonActivate.Enabled = false;
                buttonDeactivate.Enabled = true;
            }
            else
            {
                buttonActivate.Enabled = true;
                buttonDeactivate.Enabled = false;
            }
        }
        private void UcitajKorisnike()
        {
            List<User> listaKorisnika = UsersRepository.GetUsers();
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = listaKorisnika;
        }

        private void buttonDeactivate_Click(object sender, EventArgs e)
        {
            User korisnik = dataGridViewUsers.CurrentRow.DataBoundItem as User;
            korisnik.Status = UserStatus.Deactivated;
            UcitajKorisnike();
        }

        private void buttonActivate_Click(object sender, EventArgs e)
        {
            User korisnik = dataGridViewUsers.CurrentRow.DataBoundItem as User;
            korisnik.Status = UserStatus.Activated;
            UcitajKorisnike();
        }
    }
}
