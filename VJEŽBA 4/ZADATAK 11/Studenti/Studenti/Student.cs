using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studenti
{
    class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Student(TextBox ime, string prezime)
        {
            Ime = ime.Text;
            Prezime = prezime;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
