using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    public class Vrata
    {
        public int BrojVrata { get; set; }
        public int RazinaPrava { get; set; }
        public Vrata(int brojVrata, int razinaPrava)
        {
            BrojVrata = brojVrata;
            RazinaPrava = razinaPrava;
        }
    }
}
