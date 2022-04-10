using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    public interface IProstor
    {
        string Oznaka { get; set; }
        Kat Kat { get; set; }
        bool Slobodan { get; set; }

        void Prodaj(string kupac);
    }
}
