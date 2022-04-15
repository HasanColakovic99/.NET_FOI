using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometni_susret
{
    public class KontrolaSusreta
    {
        public Susret EvidentirajSusret(string oznakaDomacin, string oznakaGost, string rezultat)
        {
            Repozitorij repozitorij = new Repozitorij();
            Reprezentacija reprezentacijaDomacin = repozitorij.DohvatiReprezentaciju(oznakaDomacin);
            Reprezentacija reprezentacijaGost = repozitorij.DohvatiReprezentaciju(oznakaGost);
            string[] rez = rezultat.Split(':');
            int brojGolovaDomacin = int.Parse(rez[0]);
            int brojGolovaGost = int.Parse(rez[1]);
            Susret susret = new Susret(reprezentacijaDomacin, reprezentacijaGost, brojGolovaDomacin, brojGolovaGost);
            return susret;
        }
    }
}
