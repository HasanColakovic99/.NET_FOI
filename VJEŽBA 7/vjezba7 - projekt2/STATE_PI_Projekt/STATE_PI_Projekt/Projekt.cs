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
        public DateTime DatumPredajePrveFaze { get; set; }
        public DateTime DatumPredajeCijelogProjekta { get; set; }
        public int BrojBodova { get; set; }
        public StanjeProjekta Stanje { get; set; }

        public Projekt()
        {
            Stanje = new StanjeProjekta();
        }

        public void ZabiljeziTemu(string opisTeme, string oznakaTima)
        {
            Stanje.IzvrsiPrijelaz(EnumeracijaProjekta.Dogadaj.TimPrijavioTemu);
            OpisTeme = opisTeme;
            OznakaTima = oznakaTima;
        }

        public void PredajPrvuFazu(DateTime datumPredaje)
        {
            Stanje.IzvrsiPrijelaz(EnumeracijaProjekta.Dogadaj.StigaoRokZaPrvuFazu);
            DatumPredajePrveFaze = datumPredaje;
        }

        public void OdbijTemu()
        {
            Stanje.IzvrsiPrijelaz(EnumeracijaProjekta.Dogadaj.TemaNijeDobra);
        }

        public void PrihvatiTemu()
        {
            Stanje.IzvrsiPrijelaz(EnumeracijaProjekta.Dogadaj.TemaJeuRedu);
        }

        public void PredajCijeliProjekt(DateTime datumObrane)
        {
            Stanje.IzvrsiPrijelaz(EnumeracijaProjekta.Dogadaj.StigaoFinalniRok);
            DatumPredajeCijelogProjekta = datumObrane;
        }

        public void OcijeniProjekt(int brojBodova)
        {
            Stanje.IzvrsiPrijelaz(EnumeracijaProjekta.Dogadaj.OdrzanaObrana);
            BrojBodova = brojBodova;
        }
    }
}
