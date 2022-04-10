using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib.Iznimke
{
    public class TransactionException : BankaException
    {
        public string Poruka;
        public TransactionException(string poruka) : base(poruka)
        {
            Poruka = poruka;
        }
    }
}
