using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class Transakcija
    {
        public int Id { get; set; }

        [Browsable(false)]
        public IRacun Platitelj { get; set; }
        [Browsable(false)]
        public IRacun Primatelj { get; set; }

        public string PlatiteljOpis
        {
            get
            {
                return Platitelj.Opis;
            }
        }

        public string PrimateljOpis
        {
            get
            {
                return Primatelj.Opis;
            }
        }

        private double _isplaceniIznos;

        public double IsplaceniIznos
        {
            get { return _isplaceniIznos; }
            set { _isplaceniIznos = Math.Round(value, 2); }
        }

        public double Iznos { get; set; }

        private double _uplaceniIznos;

        public double UplaceniIznos
        {
            get { return _uplaceniIznos; }
            set { _uplaceniIznos = Math.Round(value, 2); }
        }


        public bool Provedena { get; set; }
        public DateTime Datum { get; set; }

        public Transakcija(IRacun platitelj, IRacun primatelj, double iznos)
        {
            Id = GetHashCode();
            Platitelj = platitelj;
            Primatelj = primatelj;
            Iznos = iznos;
            Datum = DateTime.Now;

            Provedena = false;
        }

        public void Provedi()
        {
            double iznosZaIsplatu = OdrediIznosZaIsplatu();
            Platitelj.Isplati(iznosZaIsplatu);
            IsplaceniIznos = iznosZaIsplatu;

            double iznosZaUplatu = OdrediIznosZaUplatu();
            Primatelj.Uplati(iznosZaUplatu);
            UplaceniIznos = iznosZaUplatu;

            Provedena = true;
        }

        public void Ponisti()
        {
            Platitelj.Uplati(IsplaceniIznos);
            Primatelj.Isplati(UplaceniIznos);
        }

        private double OdrediIznosZaIsplatu()
        {
            return Iznos;
        }

        private double OdrediIznosZaUplatu()
        {
            double iznosUplate;
            if (Platitelj.Valuta == Primatelj.Valuta)
            {
                iznosUplate = Iznos;
            }
            else
            {
                KonverterValuta konverter = new KonverterValuta();
                iznosUplate = konverter.Konvertiraj(Platitelj.Valuta, Primatelj.Valuta, Iznos);
            }

            return iznosUplate;
        }
    }
}
