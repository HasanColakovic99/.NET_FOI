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
    public partial class PopisUsera : Form
    {
        public PopisUsera()
        {
            InitializeComponent();
        }

        private void PopisUsera_Load(object sender, EventArgs e)
        {
            UcitajKorisnike();
        }


        /*
        private void Odabir(object sender, EventArgs e)
        {

            User userCurrent = korisniciDataGridView.CurrentRow.DataBoundItem as User;
            if (userCurrent.Status == UserStatus.Activated)
            {
                aktivirajButton.Enabled = false;
                deaktivirajButton.Enabled = true;
            }
            else if (userCurrent.Status == UserStatus.Deactivated)
            {
                aktivirajButton.Enabled = true;
                deaktivirajButton.Enabled = false;
            }


                    aktivirajButton.Enabled = false;
            korisniciDataGridView.SelectionChanged += Odabir;
        }
        */

        private void UcitajKorisnike()
        {
            List<User> listaKorisnika = UsersRepository.GetUsers();
            korisniciDataGridView.DataSource = null;
            korisniciDataGridView.DataSource = listaKorisnika;
        }


        private void aktivirajButton_Click(object sender, EventArgs e)
        {
            /*
            // OZNAČENI RED U DATAGRIDVIEW-u
            User korisnik = korisniciDataGridView.CurrentRow.DataBoundItem as User;
            // POSTAVLJA STATUS TOG KORISNIKA U "ACTIVATED"
            korisnik.Status = UserStatus.Activated;
            // OSJVEŽAVA LISTU
            UcitajKorisnike();
            */
        }

        private void deaktivirajButton_Click(object sender, EventArgs e)
        {
            /*
            // OZNAČENI RED U DATAGRIDVIEW-u
            User korisnik = korisniciDataGridView.CurrentRow.DataBoundItem as User;
            // POSTAVLJA STATUS TOG KORISNIKA U "DEACTIVATED"
            korisnik.Status = UserStatus.Deactivated;
            // OSVJEŽAVA LISTU
            UcitajKorisnike();
            */
        }

    }
}
