using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class TecajnaLista
    {
        private List<Tecaj> _tecaji = new List<Tecaj>();

        public TecajnaLista()
        {
            Valuta aud = Repozitorij.DohvatiValutu("AUD");
            _tecaji.Add(new Tecaj(aud, 4.07));

            Valuta cad = Repozitorij.DohvatiValutu("CAD");
            _tecaji.Add(new Tecaj(cad, 4.9));

            Valuta chf = Repozitorij.DohvatiValutu("CHF");
            _tecaji.Add(new Tecaj(chf, 7.2));

            Valuta gbp = Repozitorij.DohvatiValutu("GBP");
            _tecaji.Add(new Tecaj(gbp, 8.2));

            Valuta usd = Repozitorij.DohvatiValutu("USD");
            _tecaji.Add(new Tecaj(usd, 7.1));

            Valuta bam = Repozitorij.DohvatiValutu("BAM");
            _tecaji.Add(new Tecaj(bam, 3.88));

            Valuta eur = Repozitorij.DohvatiValutu("EUR");
            _tecaji.Add(new Tecaj(eur, 7.6));

            Valuta hrk = Repozitorij.DohvatiValutu("HRK");
            _tecaji.Add(new Tecaj(hrk, 1));
        }

        public Tecaj DohvatiTecaj(Valuta valuta)
        {
            return _tecaji.FirstOrDefault(t => t.Valuta == valuta);
        }

        public Tecaj DohvatiTecaj(string oznakaValute)
        {
            return _tecaji.FirstOrDefault(t => t.Valuta.Oznaka == oznakaValute);
        }
    }
}
