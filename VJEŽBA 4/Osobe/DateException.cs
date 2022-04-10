using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobe
{
    public class DateException : ApplicationException
    {
        public string Poruka;
        public DateException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
