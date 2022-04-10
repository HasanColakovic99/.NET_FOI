using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    public class PredmetException : ApplicationException
    {
        public string Poruka;
        public PredmetException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
