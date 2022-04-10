using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4.Models
{
    class BrojZaraženih
    {
        public int BrojZarazenih;
        public Grad Grad;
        public Država Drzava;
        public static List<BrojZaraženih> Zarazeni = new List<BrojZaraženih>();

        public BrojZaraženih(int brojZarazenih, Grad grad, Država drzava)
        {
            this.BrojZarazenih = brojZarazenih;
            this.Grad = grad;
            this.Drzava = drzava;
            Zarazeni.Add(this);
        }
    }
}
