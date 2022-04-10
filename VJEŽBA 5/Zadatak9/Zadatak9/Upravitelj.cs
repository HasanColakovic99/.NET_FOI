using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak9
{
    public class Upravitelj
    {
        double rezultat = 0;
        public List<Zgrada> listaZgrada = new List<Zgrada>();
        public double IzracunajBudzet (Zgrada zgrada)
        {
            foreach(Zgrada item in listaZgrada)
            {
                foreach(Zona zona in item.listaZona)
                {
                    rezultat += zona.IzracunajPrivucu(); 
                }
            }
            return rezultat;
        }
    }
}
