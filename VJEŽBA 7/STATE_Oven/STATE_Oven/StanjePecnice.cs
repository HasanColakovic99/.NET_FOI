using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Oven
{
    public class StanjePecnice : Enumeracija
    {
        public Stanje trenutnoStanje { get; set; }
        private Dictionary<Prijelaz, Stanje> dozvoljeniPrijelazi;

        public StanjePecnice()
        {
            trenutnoStanje = Stanje.Ugasena;
            DefinirajDozvoljenePrijelaze();
        }

        private void DefinirajDozvoljenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, Stanje>();
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Ugasena, Dogadaj.StisnutiGumbOnOff), Stanje.Upaljena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Upaljena, Dogadaj.StisnutiGumbOnOff), Stanje.Ugasena);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.Upaljena, Dogadaj.OdabranProgramPecenja), Stanje.ProgramOdabran);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.ProgramOdabran, Dogadaj.StisnutiGumbStart), Stanje.PecenjeZapoceto);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PecenjeZapoceto, Dogadaj.OdabranProgramPecenja), Stanje.ProgramOdabran);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PecenjeZapoceto, Dogadaj.IstekloVrijemePecenja), Stanje.PecenjeZavrseno);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.PecenjeZavrseno, Dogadaj.PotrebnoOhladitiPecnicu), Stanje.HladenjeGotovo);
            dozvoljeniPrijelazi.Add(new Prijelaz(Stanje.HladenjeGotovo, Dogadaj.StisnutiGumbOnOff), Stanje.Ugasena);
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
