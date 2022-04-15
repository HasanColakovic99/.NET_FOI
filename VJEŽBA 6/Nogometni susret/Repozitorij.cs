using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometni_susret
{
    public class Repozitorij
    {
        public List<Reprezentacija> listaReprezentacija;
        public Repozitorij()
        {
            listaReprezentacija = new List<Reprezentacija>();
            listaReprezentacija.Add(new Reprezentacija("HRV", "Hrvatska"));
            listaReprezentacija.Add(new Reprezentacija("GER", "Njemačka"));
            listaReprezentacija.Add(new Reprezentacija("FRA", "Francuska"));
        }
        public Reprezentacija DohvatiReprezentaciju(string oznaka)
        {
            Reprezentacija reprezentacija = null;
            foreach (Reprezentacija item in listaReprezentacija)
            {
                if (oznaka == item.Oznaka)
                    reprezentacija = item;
            }
            return reprezentacija;
        }
    }
}
