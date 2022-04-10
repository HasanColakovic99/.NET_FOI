using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak20
{
    class Program
    {
        static void Main(string[] args)
        {
            Skladište skladiste = new Skladište();

            int izbor;
            do
            {
                Console.WriteLine("1. Dodajte proizvod na skladište");
                Console.WriteLine("2. Povećaj količinu proizvoda");
                Console.WriteLine("3. Smanji količinu proizvoda");
                Console.WriteLine("4. Ispiši stanje skladište");
                Console.WriteLine("0. IZLAZ IZ PROGRAMA");
                Console.WriteLine("Vaš odabir: ");
                izbor = int.Parse(Console.ReadLine());


                switch (izbor)
                {
                    case 1:
                        {
                            Console.WriteLine("Unesite naziv proizvoda: ");
                            string naziv = Console.ReadLine();
                            Console.WriteLine("Unesite cijenu proizvoda: ");
                            int cijena = int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite stanje u skladištu: ");
                            int stanje = int.Parse(Console.ReadLine());
                            // DODAN PROIZVOD
                            Proizvod proizvod = new Proizvod(naziv, cijena, stanje);
                            // DODAN U SKLADIŠTEs
                            skladiste.DodajProizvod(proizvod);

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Unesite naziv proizvoda: ");
                            string naziv = Console.ReadLine();
                            Console.WriteLine("Unesite količinu koju želite dodati na stanje: ");
                            int kolicina = int.Parse(Console.ReadLine());

                            // PROVJERILI DA LI POSTOJI TAJ PROIZVOD I SPREMILI GA U proizvod
                            Proizvod proizvod = skladiste.DohvatiProizvod(naziv);


                            // AKO JE PROIZVOD RAZLIČIT OD NULL, ŠTO ZNAČI DA POSTOJI TAJ PROIZVOD, DODAJ MU TU KOLIČINU KOJU JE KORISNIK UNIA
                            if (proizvod != null)
                            {
                                proizvod.DodajNaStanje(kolicina);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Unesite naziv proizvoda: ");
                            string naziv = Console.ReadLine();
                            Console.WriteLine("Unesite količinu koju želite dodati na stanje: ");
                            int kolicina = int.Parse(Console.ReadLine());

                            // PROVJERILI DA LI POSTOJI TAJ PROIZVOD I SPREMILI GA U proizvod
                            Proizvod proizvod = skladiste.DohvatiProizvod(naziv);


                            // AKO JE PROIZVOD RAZLIČIT OD NULL, ŠTO ZNAČI DA POSTOJI TAJ PROIZVOD, ODUZMI MU TU KOLIČINU KOJU JE KORISNIK UNIA
                            if (proizvod != null)
                            {
                                proizvod.OduzmiSaStanja(kolicina);
                            }
                            break;
                        }
                    case 4:
                        {
                            List<Proizvod> proizvodi = skladiste.DohvatiSveProizvode();
                            foreach(Proizvod item in proizvodi)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            Console.WriteLine("Ukupna vrijednost svih zaliha u skladištu: " + skladiste.IzracunajUkupnuVrijednostSvihZaliha());
                            break;
                        }
                }


            } while (izbor != 0);
        }
    }
}
