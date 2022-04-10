using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    public class Film : IPredstava
    {
        public string Naziv { get; set; }
        public int Trajanje { get; set; }
    }
}
