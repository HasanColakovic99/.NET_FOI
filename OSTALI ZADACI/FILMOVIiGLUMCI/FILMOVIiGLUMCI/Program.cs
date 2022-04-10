using FILMOVIiGLUMCI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILMOVIiGLUMCI
{
    class Program
    {
        static void Main(string[] args)
        {

            int naredba;
            do {

                Console.WriteLine("1. Dodavanje film");
                Console.WriteLine("2. Dodavanje glumca");
                Console.WriteLine("3. Ispis svih filmova");
                Console.WriteLine("4. Ispis svih glumaca");
                Console.WriteLine("5. Dodavanje glumca u film");
                Console.WriteLine("6. Pretraga filmova po glumcima");
                Console.WriteLine("7. Izlaz iz programa");
                naredba = int.Parse(Console.ReadLine());

                switch (naredba)
                {
                    case 1:
                        {
                            Console.WriteLine("Unesite naziv filma: ");
                            string naslov = Console.ReadLine();
                            Console.WriteLine("Unesite godinu filma: ");
                            int godina = int.Parse(Console.ReadLine());
                            Film noviFilm = new Film(naslov, godina);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Unesite ime glumca: ");
                            string imeGlumca = Console.ReadLine();
                            Console.WriteLine("Unesite prezime gulmca: ");
                            string prezimeGlumca = Console.ReadLine();
                            Glumac noviGlumac = new Glumac(imeGlumca, prezimeGlumca);
                            break;
                        }
                    case 3:
                        {
                            foreach(Film item in Film.Filmovi)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach(Glumac item in Glumac.Glumci)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Unesite naziv filma: ");
                            string film = Console.ReadLine();
                            Film trazeniFilm = null;
                            foreach (Film item in Film.Filmovi)
                            {
                                if(item.Naslov.ToLower() == film.ToLower())
                                {
                                    trazeniFilm = item;
                                    break;
                                }
                            }
                            if(trazeniFilm == null)
                            {
                                Console.WriteLine("Ne postoji traženi film!");
                                break;
                            }
                            Console.WriteLine("Unesite prezime glumca: ");
                            string glumac = Console.ReadLine();
                            Glumac trazeniGlumac = null;
                            foreach(Glumac item in Glumac.Glumci)
                            {
                                if (item.Prezime == glumac)
                                {
                                    trazeniGlumac = item;
                                    break;
                                }
                            }
                            if (trazeniGlumac == null)
                            {
                                Console.WriteLine("Ne postoji glumac sa tim prezimenom!");
                                break;
                            }
                            trazeniFilm.DodajGlumca(trazeniGlumac);
                            Console.WriteLine("Glumac je uspješno dodan u film!");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Unesite glumca: ");
                            string uneseniGlumac = Console.ReadLine();

                            foreach(Film film in Film.Filmovi)
                            {
                                foreach(Glumac glumac in film.Glumci)
                                {
                                    if(glumac.Prezime.ToLower() == uneseniGlumac.ToLower())
                                    {
                                        Console.WriteLine(film.Ispis());
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                }

            } while (naredba != 7);
            Console.ReadLine();
        }
    }
}
