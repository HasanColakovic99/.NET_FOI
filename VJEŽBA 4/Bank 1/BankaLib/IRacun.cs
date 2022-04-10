using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public enum TipRacuna
    {
        Tekuci, Devizni
    }

    public enum StatusRacuna
    {
        Aktivan, Neaktivan
    }

    public interface IRacun
    {
        string IBAN { get; }
        double Stanje { get; }
        TipRacuna Tip { get; }
        string Opis { get; }
        StatusRacuna Status { get; }
        IKlijent Klijent { get; }
        Valuta Valuta { get; }

        void Uplati(double iznos);
        void Isplati(double iznos);

        void EvidentirajTransakciju(Transakcija transakcija);
        void UkloniTransakciju(Transakcija transakcija);
        List<Transakcija> DohvatiTransakcije();
        string ToString();
    }
}
