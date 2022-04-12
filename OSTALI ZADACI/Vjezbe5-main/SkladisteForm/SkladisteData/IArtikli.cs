using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteData
{
    public interface IArtikli
    {
        string Naziv { get; set; }
        int Cijena { get; set; }
        int Kolicina { get; set; }

        void DodajKolicinu();
        void OduzmiKolicinu();
    }
}
