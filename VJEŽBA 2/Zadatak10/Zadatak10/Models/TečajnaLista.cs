using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10.Models
{
    public class TečajnaLista
    {
        public static List<Tečaj> tecajnaLista = new List<Tečaj>();

        public TečajnaLista()
        {
            tecajnaLista.Add(new Tečaj("EUR", 7.5));
            tecajnaLista.Add(new Tečaj("KM", 3.85));
        }
    }
}
