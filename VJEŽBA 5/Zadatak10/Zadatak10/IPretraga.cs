using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10
{
    public interface IPretraga
    {
        bool Usporedi(string kljucnaRijec);
        string Ispisi();
    }
}
