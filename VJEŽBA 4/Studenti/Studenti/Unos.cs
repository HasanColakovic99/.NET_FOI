using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    class Unos
    {
        internal BindingList<Student> DohvatiStudenta()
        {
            return listaStudenata;
        }

        internal BindingList<Predmet> DohvatiPredmet()
        {
            return listaPredmeta;
        }

        public BindingList<Student> listaStudenata = new BindingList<Student>();
        public BindingList<Predmet> listaPredmeta = new BindingList<Predmet>();

        public void unesiStudenta(Student student)
        {
            listaStudenata.Add(student);
        }

        public void unesiPredmet(Predmet predmet)
        {
            listaPredmeta.Add(predmet);
        }
    }
}
