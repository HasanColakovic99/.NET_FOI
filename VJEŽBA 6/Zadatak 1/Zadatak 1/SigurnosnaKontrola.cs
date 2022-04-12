using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    public class SigurnosnaKontrola
    {
        public bool OtvoriVrata(int brKartice, int pin, int brVrata)
        {
            bool otvoreno = false;
            Repozitorij repozitorij = new Repozitorij();
            if(repozitorij.DohvatiKorisnika(brKartice, pin) != null && repozitorij.DohvatiVrata(brVrata) != null)
            {
                otvoreno = true;
            }
            return otvoreno;
        }
    }
}
