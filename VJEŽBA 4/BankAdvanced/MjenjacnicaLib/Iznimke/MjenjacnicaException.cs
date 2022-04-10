using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib.Iznimke
{
    public class MjenjacnicaException : SystemException
    {
        public string Poruka { get; set; }
        public MjenjacnicaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
