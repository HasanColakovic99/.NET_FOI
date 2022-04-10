using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vozilo> vozila = new List<Vozilo>();
            string unos;
            do
            {
                Console.WriteLine("1. Dodavanje vozila");
                Console.WriteLine("2. Ispis vozila");
                Console.WriteLine("0. IZLAZ");
                Console.Write("Što želite: ");
                unos = Console.ReadLine();
                switch (unos)
                {
                    case "1":
                        {
                            Console.WriteLine("Unesite naziv: ");
                            string naziv = Console.ReadLine();
                            Console.WriteLine("Unesite tip: ");
                            string tip = Console.ReadLine();

                            switch (tip)
                            {
                                case "automobil":
                                    {
                                        if(tip == "automobil")
                                        {
                                            Vozilo vozilo = new Automobil(naziv, tip);
                                            vozila.Add(vozilo);
                                        }
                                        break;
                                    }
                                case "motocikl":
                                    {
                                        if(tip == "motocikl")
                                        {
                                            Vozilo vozilo = new Motocikl(naziv, tip);
                                            vozila.Add(vozilo);
                                        }
                                        break;
                                    }
                            }

                        }
                        break;
                    case "2":
                        {
                            foreach(Vozilo item in vozila)
                            {
                                Console.WriteLine($"Naziv vozila: {item.Naziv}, Tip vozila: {item.Tip}");
                            }
                        }
                        break;
                }
            } while (unos != "0");
        }
    }
}
