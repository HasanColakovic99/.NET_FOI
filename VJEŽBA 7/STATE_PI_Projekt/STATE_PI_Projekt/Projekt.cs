using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class Projekt
    {
        public string OpisTeme { get; set; }
        public string OznakaTima { get; set; }
        public DateTime DatumPredaje { get; set; }
        public DateTime DatumObrane { get; set; }
        public StanjeProjekta2 Stanje { get; set; }

        public Projekt()
        {
            Stanje = new StanjeProjekta2();
        }

        public void ZabiljeziTemu(string opisTeme, string oznakaTima)
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.TimPrijavioTemu);
            OpisTeme = opisTeme;
            OznakaTima = oznakaTima;
        }

        public void PredajProjekt(DateTime datumPredaje)
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.DovrsenProjekt);
            DatumPredaje = datumPredaje;
        }

        public void OdbijProjekt()
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.ProjektNeZadovoljava);
        }

        public void PrihvatiProjekt()
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.ProjektZadovoljava);
        }

        public void ZakažiObranu(DateTime datumObrane)
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.OdabranTerminObrane);
            DatumObrane = datumObrane;
        }

        public void OznačiKaoObranjen()
        {
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.UspjesnaObrana);
        }
    }
}
