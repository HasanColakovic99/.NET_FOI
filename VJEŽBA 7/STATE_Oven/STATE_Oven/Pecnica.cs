using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Oven
{
    class Pecnica
    {
        public string NazivPecnice { get; set; }
        public ProgramRada Program { get; set; }
        public StanjePecnice Stanje { get; set; }

        public Pecnica()
        {
            NazivPecnice = "Electrolux 14232";
            Stanje = new StanjePecnice();
        }

        public void Upali()
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadaj.StisnutiGumbOnOff);
        }

        public void Ugasi()
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadaj.StisnutiGumbOnOff);
        }

        public void OdaberiProgram(ProgramRada program)
        {
            Program = program;
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadaj.OdabranProgramPecenja);
        }

        public void ZapocniPecenje()
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadaj.StisnutiGumbStart);
        }

        public void OznaciKaoZavrseno()
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadaj.IstekloVrijemePecenja);
        }

        public void OhladiPecnicu()
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadaj.PotrebnoOhladitiPecnicu);
        }
    }
}
