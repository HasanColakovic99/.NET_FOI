using BankaLib.Iznimke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class TekuciRacun : Racun
    {
        public double DozvoljeniMinus { get; set; }
        public double RaspoloziviIznos
        {
            get { return Stanje + DozvoljeniMinus; }
        }
        public override string Opis => $"IBAN:{IBAN}, Stanje:{Stanje}, Raspoloživo:{RaspoloziviIznos}";

        public TekuciRacun(string iban, double stanje, double dozvoljeniMinus, IKlijent klijent)
            : base(iban, stanje, klijent)
        {
            DozvoljeniMinus = dozvoljeniMinus;
            Tip = TipRacuna.Tekuci;
            Valuta = Repozitorij.DohvatiValutu("HRK");
        }

        public override void Isplati(double iznos)
        {
            Stanje -= iznos;
        }
    }
}
