using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4.Models
{
    class Grad
    {
        public string ImeGrada;
        public static List<Grad> Gradovi = new List<Grad>();

        public Grad(string imeGrada)
        {
            this.ImeGrada = imeGrada;
            Gradovi.Add(this);
        }

        public string Ispis()
        {
            return ImeGrada;
        }
    }
}
