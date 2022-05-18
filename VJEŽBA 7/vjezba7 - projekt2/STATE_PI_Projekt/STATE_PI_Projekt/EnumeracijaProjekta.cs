using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class EnumeracijaProjekta
    {
        public enum Stanje
        {
            TemaNijePrijavljena,
            TemaPrijavljena,
            TemaPrihvacena,
            PredanaPrvaFaza,
            PredanProjekt,
            ProjektOcijenjen
        }
        public enum Dogadaj
        {
            TimPrijavioTemu,
            TemaNijeDobra,
            TemaJeuRedu,
            StigaoRokZaPrvuFazu,
            StigaoFinalniRok,
            OdrzanaObrana
        }
    }
}
