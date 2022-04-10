using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3.Models
{
    class Bodovi
    {
        public int BodoviStudenta;
        public Student Student;
        public Vježbe Vjezba;
        public static List<Bodovi> SviBodovi = new List<Bodovi>();

        public Bodovi(int bodovistudenta, Student student, Vježbe vjezba)
        {
            this.BodoviStudenta = bodovistudenta;
            this.Student = student;
            this.Vjezba = vjezba;
            SviBodovi.Add(this);
        }
    }
}
