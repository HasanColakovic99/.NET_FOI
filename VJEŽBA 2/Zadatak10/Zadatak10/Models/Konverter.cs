using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10.Models
{
    public class Konverter
    {
        public TečajnaLista Lista = new TečajnaLista();
        public double konvertirano = 0;
        public double Konvertiraj(double kune, string valuta)
        {
            foreach(Tečaj item in TečajnaLista.tecajnaLista)
            {
                if(item.Valuta == valuta)
                {
                    konvertirano = kune / item.TecajValute;
                }
            }
            return konvertirano;
        }
    }
}
