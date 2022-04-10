using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba2
{
    public class TečajnaLista
    {
        public static List<Tečaj> TecajnaLista = new List<Tečaj>();

        public TečajnaLista()
        {
            TecajnaLista.Add(new Tečaj("EUR", 7.5));
            TecajnaLista.Add(new Tečaj("KM", 3.85));
        }
    }
}
