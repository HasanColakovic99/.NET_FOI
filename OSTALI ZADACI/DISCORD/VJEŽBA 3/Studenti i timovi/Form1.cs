using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentiTimoviLib;

namespace Studenti_i_timovi
{
    public partial class FormGlavna : Form
    {
        public List<Student> popisNedodjeljenihStudenata;
        public List<Tim> popisTimova;
        public List<Student> popisStudenataUTimu = new List<Student>();
        public Tim PosljednjeOdabrani = null;
        public FormGlavna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            popisNedodjeljenihStudenata = KolegijManager.DohvatiNedodijeljeneStudente();
            listBoxNedodjeljeniStudenti.DataSource = null;
            listBoxNedodjeljeniStudenti.DataSource = popisNedodjeljenihStudenata;
            popisTimova = KolegijManager.DohvatiTimove();
            listBoxTimovi.DataSource = null;
            listBoxTimovi.DataSource = popisTimova;
            Tim odabraniTim = listBoxTimovi.SelectedItem as Tim;
            IspisiTim();
        }

        private void ButtonUkloniIzTima_Click(object sender, EventArgs e)
        {
            Student ukloniStudenta = listBoxClanoviTima.SelectedItem as Student;
            Tim odabraniTim = listBoxTimovi.SelectedItem as Tim;
            KolegijManager.UkloniIzTima(ukloniStudenta, odabraniTim);
            Osvjezi();
        }
        

        private void IspisiTim()
        {
            if(listBoxTimovi.SelectedItem != null)
            {
                Tim odabraniTim = listBoxTimovi.SelectedItem as Tim;
                PosljednjeOdabrani = odabraniTim;
                popisStudenataUTimu = KolegijManager.DohvatiStudenteTima(odabraniTim);
                listBoxClanoviTima.DataSource = null;
                listBoxClanoviTima.DataSource = popisStudenataUTimu;
            }
        }

        private void ButtonDodajUTim_Click(object sender, EventArgs e)
        {
            Student odabraniStudent = listBoxNedodjeljeniStudenti.SelectedItem as Student;
            Tim odabraniTim = listBoxTimovi.SelectedItem as Tim;
            KolegijManager.DodajUTim(odabraniStudent, odabraniTim);
            popisNedodjeljenihStudenata.Remove(odabraniStudent);
            IspisiTim();
            Osvjezi();
        }

        private void listBoxTimovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            IspisiTim();
        }

        private void ButtonNoviStudent_Click(object sender, EventArgs e)
        {
            FormNoviStudent novaForma = new FormNoviStudent();
            novaForma.ShowDialog();
            Osvjezi();
        }
    }
}
