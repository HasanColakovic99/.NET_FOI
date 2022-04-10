using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib.Iznimke
{
    public class MjenjacninaException : ApplicationException
    {
        public string Poruka { get; set; }

        public MjenjacninaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
