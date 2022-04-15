using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopisZadataka1
{
    public class Zadatak
    {
        public string Naziv { get; set; }
        public DateTime Rok { get; set; }

        public Zadatak(string naziv, DateTime rok)
        {
            Naziv = naziv;
            Rok = rok;
        }
    }
}
