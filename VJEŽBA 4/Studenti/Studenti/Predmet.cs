using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    class Predmet
    {
        public string Naziv { get; set; }

        public Predmet(string naziv)
        {
            if(naziv == string.Empty)
            {
                throw new PredmetException("Morate unijet ime predmeta");
            }
            Naziv = naziv;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
