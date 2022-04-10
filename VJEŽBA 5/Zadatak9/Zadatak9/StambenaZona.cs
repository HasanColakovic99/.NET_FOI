using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak9
{
    public class StambenaZona : Zona
    {
        public override double IzracunajPrivucu()
        {
            double rezultat = 0;
            foreach(Prostor item in listaProstora)
            {
                rezultat += item.Površina * 2;
            }
            return rezultat;
        }
    }
}
