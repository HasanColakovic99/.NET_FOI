using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba2
{
    public class KonverterValuta
    {
        public List<Tečaj> TecajnaLista = new List<Tečaj>();

        public double Konvertiraj(string valuta, int iznos)
        {
            double rezultat = 0;
            foreach(Tečaj item in this.TecajnaLista)
            {
                if(item.Valuta == valuta)
                {
                    rezultat = item.Tecaj * iznos;
                }
            }
            return rezultat;
        }

    }
}
