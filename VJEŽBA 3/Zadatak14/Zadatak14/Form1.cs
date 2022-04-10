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

namespace Zadatak14
{
    public partial class Form1 : Form
    {
        List<Student> listaStudenata = new List<Student>();
        List<Tim> listaTimova = new List<Tim>();
        List<Student> listaStudentauTimu = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ListaStudenta()
        {
            listaStudenata = KolegijManager.DohvatiNedodijeljeneStudente();
            prvaLista.DataSource = null;
            prvaLista.DataSource = listaStudenata;
        }

        private void ListaTimova()
        {
            listaTimova = KolegijManager.DohvatiTimove();
            drugaLista.DataSource = null;
            drugaLista.DataSource = listaTimova;
        }


        private void ListaStudenataUTimu()
        {
            if (drugaLista.SelectedItem != null)
            {
                listaStudentauTimu = KolegijManager.DohvatiStudenteTima(drugaLista.SelectedItem as Tim);
                trecaLista.DataSource = null;
                trecaLista.DataSource = listaStudentauTimu;
            }
        }

        private void Osvjezi()
        {
            ListaStudenta();
            ListaTimova();
            ListaStudenataUTimu();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }


        private void DodajUTim()
        {
            Student student;
            Tim tim;
            student = prvaLista.SelectedItem as Student;
            tim = drugaLista.SelectedItem as Tim;
            KolegijManager.DodajUTim(student, tim);
        }

        private void dodajUTimButton_Click(object sender, EventArgs e)
        {
            DodajUTim();
            Osvjezi();
        }

        private void DodajStudentaUTim(object sender, EventArgs e)
        {
            Tim tim;
            tim = drugaLista.SelectedItem as Tim;
            ListaStudenataUTimu();
        }

        private void ukloniIzTimaButton_Click(object sender, EventArgs e)
        {
            Student student;
            student = trecaLista.SelectedItem as Student;
            Tim tim;
            tim = drugaLista.SelectedItem as Tim;
            KolegijManager.UkloniIzTima(student, tim);
            Osvjezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Novi_student noviStudent = new Novi_student();
            noviStudent.ShowDialog();
            Osvjezi();
        }
    }
}
