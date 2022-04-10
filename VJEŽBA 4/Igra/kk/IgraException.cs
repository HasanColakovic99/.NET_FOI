using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kk
{
    public class IgraException : ApplicationException
    {
        public string Poruka { get; set; }
        public IgraException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
