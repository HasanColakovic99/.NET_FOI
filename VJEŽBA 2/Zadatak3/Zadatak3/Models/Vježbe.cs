using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3.Models
{
    class Vježbe
    {
        public string ImeVježbe;
        public List<Student> Studenti = new List<Student>();
        public static List<Vježbe> Vjezbe = new List<Vježbe>();
        public Vježbe(string imeVjezbe)
        {
            this.ImeVježbe = imeVjezbe;
            Vjezbe.Add(this);
        }

        public void DodajStudenta(Student student)
        {
            if (!Studenti.Contains(student))
            {
                Studenti.Add(student);
            }
                
        }

        public string Ispis()
        {
            string returnMe = "";
            returnMe = "Ime vježbe: " + ImeVježbe + " (";
            foreach(Student item in this.Studenti)
            {
                int bodovi = 0;
                foreach(Bodovi bod in Bodovi.SviBodovi)
                {
                    if (bod.Vjezba.ImeVježbe == ImeVježbe && bod.Student.Ime == item.Ime && bod.Student.Prezime == item.Prezime)
                    {
                        bodovi = bod.BodoviStudenta;
                    }
                }
                returnMe += item.Ime + " " + item.Prezime + " - " + bodovi + ", ";
            }
            returnMe += ")";
            return returnMe;
        }

        public static string KonacniIspis()
        {
            string returnMe = "";
            foreach (Student item in Student.Studenti)
            {
                int bodovi = 0;
                foreach (Bodovi bod in Bodovi.SviBodovi)
                {
                    if (bod.Student.Ime == item.Ime && bod.Student.Prezime == item.Prezime)
                    {
                        bodovi += bod.BodoviStudenta;
                    }
                }
                returnMe += item.Ime + " " + item.Prezime + " - " + bodovi + ", ";
            }
            return returnMe;
        }
    }
}
