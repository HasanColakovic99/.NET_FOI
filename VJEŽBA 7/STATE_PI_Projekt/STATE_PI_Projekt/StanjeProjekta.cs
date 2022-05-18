using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class StanjeProjekta : ProjektEnumeracija
    {
        public Stanje trenutnoStanje { get; set; }
        public Dictionary<Prijelaz, Stanje> dozvoljeniPrijelazi;

        public StanjeProjekta()
        {
            trenutnoStanje = Stanje.NijePrijavljenaTema;
            DefinirajDozvoljenePrijelaze();
        }

        private void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, Stanje>();
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.NijePrijavljenaTema, Dogadaj.TimPrijavioTemu), Stanje.TemaPrijavljena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.TemaPrijavljena, Dogadaj.DovrsenProjekt), Stanje.PredanProjekt);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PredanProjekt, Dogadaj.ProjektNeZadovoljava), Stanje.TemaPrijavljena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PredanProjekt, Dogadaj.ProjektZadovoljava), Stanje.PrihvacenProjekt);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PrihvacenProjekt, Dogadaj.OdabranTerminObrane), Stanje.ZakazanaObrana);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.ZakazanaObrana, Dogadaj.UspjesnaObrana), Stanje.ObranjenProjekt);
        }

        public void IzvrsiPrijelaz(Dogadaj aktivacijskiDogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(trenutnoStanje, aktivacijskiDogadaj);
            Stanje ciljanoStanje;

            if(dozvoljeniPrijelazi.TryGetValue(prijelaz, out ciljanoStanje) == false)
            {
                throw new ApplicationException($"Prijelaz {trenutnoStanje} -> {aktivacijskiDogadaj} nije moguc");
            }
            trenutnoStanje = ciljanoStanje;
        }
        public override string ToString()
        {
            return trenutnoStanje.ToString();
        }
    }
}
