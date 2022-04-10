using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila
{
    public abstract class Vozilo
    { 
        public string Naziv { get; set; }
        public abstract string Tip{ get; }
    }
}
