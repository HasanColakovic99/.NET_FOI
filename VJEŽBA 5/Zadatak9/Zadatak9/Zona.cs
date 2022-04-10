using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak9
{
    public abstract class Zona
    {
        public string NazivZone { get; set; }
        public List<Prostor> listaProstora = new List<Prostor>();

        public abstract double IzracunajPrivucu();
    }
}
