using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public static class Repozitorij
    {
        public static List<Transakcija> Transakcije { get; set; }

        public static void UcitajPodatke()
        {
            InicijalizirajValute();
            InicijalizirajKlijente();
            InicijalizirajRacune();
            InicijalizirajTransakcije();
        }

        private static void InicijalizirajTransakcije()
        {
            Transakcije = new List<Transakcija>();
            Banka.ProvediTransakciju(DohvatiRacun("HR11"), DohvatiRacun("HR12"), 550);
            Banka.ProvediTransakciju(DohvatiRacun("HR11"), DohvatiRacun("HR13"), 1200);
            Banka.ProvediTransakciju(DohvatiRacun("HR12"), DohvatiRacun("HR13"), 800);
            Banka.ProvediTransakciju(DohvatiRacun("HR13"), DohvatiRacun("HR14"), 220);
            Banka.ProvediTransakciju(DohvatiRacun("HR14"), DohvatiRacun("HR51"), 450);
            Banka.ProvediTransakciju(DohvatiRacun("HR51"), DohvatiRacun("HR52"), 120);
            Banka.ProvediTransakciju(DohvatiRacun("HR52"), DohvatiRacun("HR53"), 150);
        }

        public static List<IRacun> Racuni { get; private set; }

        private static void InicijalizirajRacune()
        {
            Racuni = new List<IRacun>();

            Racuni.Add(new TekuciRacun("HR11", 12000, 0, Klijenti[0]));
            Racuni.Add(new TekuciRacun("HR12", 8000, 0, Klijenti[1]));
            Racuni.Add(new TekuciRacun("HR13", 9000, 5000, Klijenti[2]));
            Racuni.Add(new TekuciRacun("HR14", 3200, 3000, Klijenti[3]));
            Racuni.Add(new TekuciRacun("HR15", 6500, 2000, Klijenti[4]));
            Racuni.Add(new DevizniRacun("HR51", 1000, DohvatiValutu("EUR"), Klijenti[0]));
            Racuni.Add(new DevizniRacun("HR52", 500, DohvatiValutu("USD"), Klijenti[0]));
            Racuni.Add(new DevizniRacun("HR53", 800, DohvatiValutu("CHF"), Klijenti[1]));
            Racuni.Add(new DevizniRacun("HR54", 700, DohvatiValutu("BAM"), Klijenti[1]));
            Racuni.Add(new DevizniRacun("HR55", 800, DohvatiValutu("EUR"), Klijenti[2]));
            Racuni.Add(new DevizniRacun("HR56", 700, DohvatiValutu("EUR"), Klijenti[3]));

            Racuni.Add(new TekuciRacun("HR12", 100000, 0, Klijenti[5]));
            Racuni.Add(new TekuciRacun("HR17", 111500, 0, Klijenti[6]));
            Racuni.Add(new TekuciRacun("HR18", 80000, 0, Klijenti[7]));
            Racuni.Add(new TekuciRacun("HR19", 60000, 0, Klijenti[8]));
            Racuni.Add(new TekuciRacun("HR20", 6500, 0, Klijenti[9]));
            Racuni.Add(new DevizniRacun("HR57", 4000, DohvatiValutu("EUR"), Klijenti[5]));
            Racuni.Add(new DevizniRacun("HR58", 500, DohvatiValutu("USD"), Klijenti[5]));
            Racuni.Add(new DevizniRacun("HR59", 800, DohvatiValutu("CHF"), Klijenti[6]));
            Racuni.Add(new DevizniRacun("HR60", 700, DohvatiValutu("BAM"), Klijenti[7]));
            Racuni.Add(new DevizniRacun("HR61", 800, DohvatiValutu("EUR"), Klijenti[8]));
            Racuni.Add(new DevizniRacun("HR62", 700, DohvatiValutu("EUR"), Klijenti[9]));
        }

        public static List<IRacun> DohvatiRacune()
        {
            return Racuni;
        }

        public static List<IRacun> DohvatiRacune(IKlijent klijent)
        {
            return Racuni.FindAll(r => r.Klijent == klijent);
        }

        public static IRacun DohvatiRacun(string iban)
        {
            return Racuni.FirstOrDefault(r => r.IBAN == iban);
        }

        public static List<IKlijent> Klijenti { get; private set; }

        public static List<IKlijent> DohvatiKlijente()
        {
            return Klijenti;
        }

        public static IKlijent DohvatiKlijenta(string oib)
        {
            return Klijenti.FirstOrDefault(k => k.Osoba.OIB == oib);
        }

        private static void InicijalizirajKlijente()
        {
            Klijenti = new List<IKlijent>();

            Klijenti.Add(new PrivatniKlijent("1111111111111", "Pero", "Perić"));
            Klijenti.Add(new PrivatniKlijent("2222222222222", "Ivana", "Lukić"));
            Klijenti.Add(new PrivatniKlijent("3333333333333", "Luka", "Novak"));
            Klijenti.Add(new PrivatniKlijent("4444444444444", "Marko", "Horvat"));
            Klijenti.Add(new PrivatniKlijent("5555555555555", "Marija", "Perić"));

            Klijenti.Add(new PoslovniKlijent("6666666666666", "Alfa d.o.o.", "Davor", "Majić"));
            Klijenti.Add(new PoslovniKlijent("7777777777777", "Beta d.o.o.", "Ivan", "Ivanović"));
            Klijenti.Add(new PoslovniKlijent("8888888888888", "Gama d.o.o.", "Ana", "Horvat"));
            Klijenti.Add(new PoslovniKlijent("9999999999999", "Delta d.o.o.", "Marta", "Klarić"));
            Klijenti.Add(new PoslovniKlijent("1000000000000", "Omega d.o.o.", "Igor", "Lukić"));
        }

        public static List<Valuta> Valute { get; private set; }

        static void InicijalizirajValute()
        {
            Valute = new List<Valuta>();

            Valute.Add(new Valuta { Oznaka = "AUD", Zemlja = "Australija" });
            Valute.Add(new Valuta { Oznaka = "CAD", Zemlja = "Kanada" });
            Valute.Add(new Valuta { Oznaka = "CHF", Zemlja = "Švicarska" });
            Valute.Add(new Valuta { Oznaka = "GBP", Zemlja = "V. Britanija"});
            Valute.Add(new Valuta { Oznaka = "USD", Zemlja = "SAD" });
            Valute.Add(new Valuta { Oznaka = "BAM", Zemlja = "BiH" });
            Valute.Add(new Valuta { Oznaka = "EUR", Zemlja = "EMU" });
            Valute.Add(new Valuta { Oznaka = "HRK", Zemlja = "Hrvatska" });
        }

        public static Valuta DohvatiValutu(string oznaka)
        {
            return Valute.FirstOrDefault(v => v.Oznaka == oznaka);
        }

        public static List<Valuta> DohvatiValute()
        {
            return Valute;
        }

        public static List<Transakcija> DohvatiTransakcije()
        {
            return Transakcije;
        }

        public static Transakcija DohvatiTransakciju(int id)
        {
            return Transakcije.FirstOrDefault(t => t.Id == id);
        }
    }
}
