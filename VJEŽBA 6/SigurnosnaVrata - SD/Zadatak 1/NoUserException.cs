using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    public class NoUserException : SystemException
    {
        public string Poruka { get; set; }
        public NoUserException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
