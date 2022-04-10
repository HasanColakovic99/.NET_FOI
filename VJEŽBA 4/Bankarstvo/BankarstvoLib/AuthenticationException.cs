using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarstvoLib
{
    public class AuthenticationException : ApplicationException
    {
        public string Poruka { get; set; }
        public AuthenticationException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
