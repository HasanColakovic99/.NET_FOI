using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Oven
{
    public class Enumeracija
    {
        public enum Stanje
        {
            Ugasena,
            HladenjeGotovo,
            PecenjeZavrseno,
            PecenjeZapoceto,
            ProgramOdabran,
            Upaljena
        }
        public enum Dogadaj
        {
            StisnutiGumbOnOff,
            PotrebnoOhladitiPecnicu,
            IstekloVrijemePecenja,
            StisnutiGumbStart,
            OdabranProgramPecenja,
        }
    }
}
