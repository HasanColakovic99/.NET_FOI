using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class Film
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; }

        public Film(int id, string naziv, int trajanje)
        {
            ID = id;
            Naziv = naziv;
            Trajanje = trajanje;
        }
    }
}
