using BankaLib.Iznimke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public abstract class Racun : IRacun
    {
        public string IBAN { get; protected set; }

        private double _stanje;

        public double Stanje
        {
            get { return _stanje; }
            set
            {
                _stanje = Math.Round(value, 2);
            }
        }


        public abstract string Opis { get; }
        public TipRacuna Tip { get; protected set; }
        public StatusRacuna Status { get; protected set; }
        public IKlijent Klijent { get; protected set; }
        public Valuta Valuta { get; protected set; }
        private List<Transakcija> ProvedeneTransakcije { get; set; }

        public Racun(string iban, double stanje, IKlijent klijent)
        {
            IBAN = iban;
            Stanje = stanje;
            Status = StatusRacuna.Aktivan;
            Klijent = klijent;

            ProvedeneTransakcije = new List<Transakcija>();
        }

        public virtual void Uplati(double iznos)
        {
            Stanje += iznos;

        }

        public virtual void Isplati(double iznos)
        {
            Stanje -= iznos;
        }

        public void EvidentirajTransakciju(Transakcija transakcija)
        {
            ProvedeneTransakcije.Add(transakcija);
        }

        public void UkloniTransakciju(Transakcija transakcija)
        {
            ProvedeneTransakcije.Remove(transakcija);
        }

        public List<Transakcija> DohvatiTransakcije()
        {
            return ProvedeneTransakcije;
        }
    }
}
