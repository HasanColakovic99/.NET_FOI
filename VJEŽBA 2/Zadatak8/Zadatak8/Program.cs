using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak8.Models;

namespace Zadatak8
{
    class Program
    {
        static void Main(string[] args)
        {
            Knjižnica novaKnjiga = new Knjižnica();
            do
            {
                Console.WriteLine("Unesite naslov knjige: ");
                string naslov = Console.ReadLine();
                Console.WriteLine("Unesite ime osobe: ");
                string ime = Console.ReadLine();
                novaKnjiga.Posudi(naslov, ime);
                novaKnjiga.Ispis();
            } while (true);
        }
    }
}
