using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankarstvoLib;

namespace BankarstvoLib
{
    public class Uplata : UplataBase, Transakcija
    {
        public override void Provedi()
        {
            Racun.Stanje += Iznos;
            Datum = DateTime.Now;
        }
    }
}
