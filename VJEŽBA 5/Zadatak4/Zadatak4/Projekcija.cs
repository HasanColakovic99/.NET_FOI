using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    public class Projekcija
    {
        public DateTime Datum { get; set; }
        public Dvorana Dvorana { get; set; }
        public IPredstava Predstava { get; set; }
    }
}
