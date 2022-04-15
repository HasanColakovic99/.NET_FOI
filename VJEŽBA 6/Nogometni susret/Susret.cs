using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometni_susret
{
    public class Susret
    {
        public Reprezentacija reprezentacijaDomacin { get; set; }
        public Reprezentacija reprezentacijaGost { get; set; }
        public int brojGolovaDomacin { get; set; }
        public int brojGolovaGost { get; set; }
        public Susret(Reprezentacija domacin, Reprezentacija gost, int brojDomacina, int brojGosta)
        {
            reprezentacijaDomacin = domacin;
            brojGolovaDomacin = brojDomacina;
            reprezentacijaGost = gost;
            brojGolovaGost = brojGosta;
        }
    }
}
