using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak9.Models;

namespace Zadatak9
{
    class Program
    {
        static void Main(string[] args)
        {
            Knjižnica novaKnjiznica = new Knjižnica();
            Console.WriteLine("Unesite ime i prezime osobe kojoj posuđujemo knjigu: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite ISBN knjige: ");
            string isbn = Console.ReadLine();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("--------------- POSUDBA ------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(novaKnjiznica.PosudiKnjigu(ime, isbn));
            Console.ReadLine();
        }
    }
}
