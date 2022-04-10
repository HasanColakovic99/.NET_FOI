using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3.Models
{
    class Student
    {
        public string Ime;
        public string Prezime;
        public static List<Student> Studenti = new List<Student>();

        public Student(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            Studenti.Add(this);
        }

        public string Ispis()
        {
            return Ime + " " + Prezime; 
        }
    }
}
