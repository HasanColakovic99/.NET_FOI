using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak16.Models;

namespace Zadatak16
{
    class Program
    {
        static void Main(string[] args)
        {
            Prvenstvo prvenstvo = new Prvenstvo();
            
            string izbor;
            do
            {
                Console.WriteLine("[1] Unesi reprezentaciju");
                Console.WriteLine("[2] Evidentiraj utakmicu");
                Console.WriteLine("[3] Ispisi tablicu rezultata");
                Console.WriteLine("[4] Ispisi bodovnu ljestvicu");
                Console.WriteLine("[9] Izlaz");
                Console.WriteLine("--------------------");
                Console.WriteLine("\nUnesite vaš odabir: ");
                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        {
                            Console.WriteLine("Unesite oznaku reprezentacije: ");
                            string oznaka = Console.ReadLine();
                            Console.WriteLine("Unesite naziv reprezentacije: ");
                            string nazivrepke = Console.ReadLine();
                            Reprezentacija reprezentacija = new Reprezentacija(oznaka, nazivrepke);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Unesite domaćina: ");
                            string domacin = Console.ReadLine();
                            Console.WriteLine("Unesite gosta: ");
                            string gost = Console.ReadLine();
                            Console.WriteLine("Unesite broj golova domaćina: ");
                            int golovidomacina = int.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite broj golova gosta: ");
                            int golovigosta = int.Parse(Console.ReadLine());
                            Reprezentacija domacin0 = new Reprezentacija();
                            Reprezentacija gost0 = new Reprezentacija();
                            foreach(Reprezentacija item in Reprezentacija.Reprezentacije)
                            {
                                if(item.Oznaka == domacin)
                                {
                                    domacin0 = item;
                                }
                                if(item.Oznaka == gost)
                                {
                                    gost0 = item;
                                }
                            }
                            Utakmica utakmica = new Utakmica(domacin0, gost0, golovidomacina, golovigosta);
                            Console.WriteLine(utakmica.GenerirajIspis());
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine(prvenstvo.GenerirajTablicuRezultata());
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("BODOVNA LJESTVICA");
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.WriteLine("REP\tOU\tPOB\tNER\tIZG\tGR+\tGR-\tGR\tBODOVI");
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.WriteLine(prvenstvo.GenerirajBodovnuLjestvicu());
                            break;
                        }
                }

            } while (izbor != "9");


        }
    }
}
