using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class Enumeracija
    {
        public enum Stanje
        {
            NijePrijavljenaTema,
            TemaPrijavljena,
            PredanProjekt,
            PrihvacenProjekt,
            ZakazanaObrana,
            ObranjenProjekt
        }

        public enum Dogadjaj
        {
            TimPrijavioTemu,
            DovrsenProjekt,
            ProjektNeZadovoljava,
            ProjektProvjeren,
            ProjektZadovoljava,
            OdabranTerminObrane,
            UspjesnaObrana
        }
    }
}
