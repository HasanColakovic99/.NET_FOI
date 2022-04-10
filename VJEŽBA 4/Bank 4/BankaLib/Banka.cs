using BankaLib.Iznimke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public static class Banka
    {
        static Banka()
        {

        }

        public static IRacun OtvoriTekuciRacun(string iban, double pocetnoStanje, double dozvoljeniMinus, IKlijent klijent)
        {
            IRacun racun = new TekuciRacun(iban, pocetnoStanje, dozvoljeniMinus, klijent);
            Repozitorij.Racuni.Add(racun);
            return racun;
        }

        public static string GenerirajJedinstvenIBAN()
        {
            IbanGenerator generator = new IbanGenerator();

            string iban;
            do
            {
                iban = generator.Generiraj();
            }
            while (Repozitorij.DohvatiRacun(iban) != null);

            return iban;
        }

        public static IKlijent KreirajPoslovnogKlijenta(string oib, string poduzece, string ime, string prezime)
        {
            IKlijent klijent = new PoslovniKlijent(oib, poduzece, ime, prezime);
            Repozitorij.Klijenti.Add(klijent);
            return klijent;
        }

        public static IKlijent KreirajPrivatnogKlijenta(string oib, string ime, string prezime)
        {
            IKlijent klijent = new PrivatniKlijent(oib, ime, prezime);
            Repozitorij.Klijenti.Add(klijent);
            return klijent;
        }

        public static void ProvediTransakciju(IRacun platitelj, IRacun primatelj, double iznos)
        {
            Transakcija transakcija = new Transakcija(platitelj, primatelj, iznos);
            transakcija.Provedi();

            PohraniTransakciju(platitelj, primatelj, transakcija);

            if (transakcija.Provedena == false)
            {
                transakcija.Ponisti();
            }
        }

        private static void PohraniTransakciju(IRacun platitelj, IRacun primatelj, Transakcija transakcija)
        {
            platitelj.EvidentirajTransakciju(transakcija);
            primatelj.EvidentirajTransakciju(transakcija);
            Repozitorij.Transakcije.Add(transakcija);
        }

        private static void UkloniTransakciju(IRacun platitelj, IRacun primatelj, Transakcija transakcija)
        {
            platitelj.UkloniTransakciju(transakcija);
            primatelj.UkloniTransakciju(transakcija);
            Repozitorij.Transakcije.Remove(transakcija);
        }

        public static IRacun OtvoriDevizniRacun(string iban, double stanje, string oznakaValute, IKlijent klijent)
        {
            Valuta valuta = Repozitorij.DohvatiValutu(oznakaValute);
            IRacun racun = new DevizniRacun(iban, stanje, valuta, klijent);
            Repozitorij.Racuni.Add(racun);
            return racun;
        }
    }
}
