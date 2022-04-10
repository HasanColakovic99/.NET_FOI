using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak2.Models;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Banka banka = new Banka();
            Console.WriteLine("Unesite IBAN platitelja: ");
            string platitelj = Console.ReadLine();
            Console.WriteLine("Unesite IBAN primatelja: ");
            string primatelj = Console.ReadLine();
            Console.WriteLine("Unesite iznos plaćanja: ");
            double iznos = double.Parse(Console.ReadLine());

            Transakcija novaTransakcija = banka.IzvrsiPlacanje(platitelj, primatelj, iznos);
            Console.WriteLine($"Novo stanje računa {novaTransakcija.Platitelj.IBAN} je {novaTransakcija.Platitelj.Stanje}");
            Console.WriteLine($"Novo stanje računa {novaTransakcija.Primatelj.IBAN} je {novaTransakcija.Primatelj.Stanje}");
            Console.ReadLine();
        }
    }
}
