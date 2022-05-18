using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class StanjeProjekta2 : Enumeracija
    {
        public Stanje TrenutnoStanje { get; set; }
        public Dictionary<Prijelaz2, Stanje> dozvoljeniPrijelazi;

        public StanjeProjekta2()
        {
            TrenutnoStanje = Stanje.NijePrijavljenaTema;
            DefinirajDozvoljenePrijelaze();
        }

        private void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz2, Stanje>();
            dozvoljeniPrijelazi.Add(new Prijelaz2(Stanje.NijePrijavljenaTema, Dogadjaj.TimPrijavioTemu), Stanje.TemaPrijavljena);
            dozvoljeniPrijelazi.Add(new Prijelaz2(Stanje.TemaPrijavljena, Dogadjaj.DovrsenProjekt), Stanje.PredanProjekt);
            dozvoljeniPrijelazi.Add(new Prijelaz2(Stanje.PredanProjekt, Dogadjaj.ProjektNeZadovoljava), Stanje.TemaPrijavljena);
            dozvoljeniPrijelazi.Add(new Prijelaz2(Stanje.PredanProjekt, Dogadjaj.ProjektZadovoljava), Stanje.PrihvacenProjekt);
            dozvoljeniPrijelazi.Add(new Prijelaz2(Stanje.PrihvacenProjekt, Dogadjaj.OdabranTerminObrane), Stanje.ZakazanaObrana);
            dozvoljeniPrijelazi.Add(new Prijelaz2(Stanje.ZakazanaObrana, Dogadjaj.UspjesnaObrana), Stanje.ObranjenProjekt);
        }

        public void IzvrsiPrijelaz(Dogadjaj aktivacijskiDogadjaj)
        {
            Prijelaz2 prijelaz = new Prijelaz2(TrenutnoStanje, aktivacijskiDogadjaj);
            Stanje ciljanoStanje;
            if(dozvoljeniPrijelazi.TryGetValue(prijelaz, out ciljanoStanje) == false)
            {
                throw new ApplicationException("Taj prijelaz nije definiran!");
            }
            TrenutnoStanje = ciljanoStanje;
        }

        public override string ToString()
        {
            return TrenutnoStanje.ToString();
        }
    }
}
