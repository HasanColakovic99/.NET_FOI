using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    public class StanjeProjekta : EnumeracijaProjekta
    {
        public Stanje TrenutnoStanje { get; set; }
        public Dictionary<Prijelaz, Stanje> dozvoljeniPrijelazi;
        public StanjeProjekta()
        {
            TrenutnoStanje = Stanje.TemaNijePrijavljena;
            DefinirajDozvoljenePrijelaze();
        }

        private void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, Stanje>();
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.TemaNijePrijavljena, Dogadaj.TimPrijavioTemu), Stanje.TemaPrijavljena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.TemaPrijavljena, Dogadaj.TemaNijeDobra), Stanje.TemaNijePrijavljena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.TemaPrijavljena, Dogadaj.TemaJeuRedu), Stanje.TemaPrihvacena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.TemaPrihvacena, Dogadaj.StigaoRokZaPrvuFazu), Stanje.PredanaPrvaFaza);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PredanaPrvaFaza, Dogadaj.StigaoFinalniRok), Stanje.PredanProjekt);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PredanProjekt, Dogadaj.OdrzanaObrana), Stanje.ProjektOcijenjen);
        }

        public void IzvrsiPrijelaz(Dogadaj aktivacijskiDogadaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutnoStanje, aktivacijskiDogadaj);
            Stanje ciljanoStanje;
            if(dozvoljeniPrijelazi.TryGetValue(prijelaz, out ciljanoStanje) == false)
            {
                throw new ApplicationException($"Prijelaz {TrenutnoStanje} -> {aktivacijskiDogadaj} nije moguc");
            }
            TrenutnoStanje = ciljanoStanje;
        }
        public override string ToString()
        {
            return TrenutnoStanje.ToString();
        }
    }
}
