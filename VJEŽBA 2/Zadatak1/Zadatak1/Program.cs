using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak1.Models;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite polaziste, odrediste i tip karte");
            string[] uneseniPodaci = Console.ReadLine().Split(' ');

            string polaziste = uneseniPodaci[0];
            string odrediste = uneseniPodaci[1];
            string tipKarte = uneseniPodaci[2];

            AutobusniKolodvor kolodvor = new AutobusniKolodvor();
            Console.WriteLine(kolodvor.KupiKartu(polaziste, odrediste, tipKarte)); 
            Console.ReadLine();
        }
    }
}
