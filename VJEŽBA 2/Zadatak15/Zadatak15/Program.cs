using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak15.Models;

namespace Zadatak15
{
    class Program
    {
        static void Main(string[] args)
        {
            Autentifikator autentifikator = new Autentifikator();

            Console.WriteLine("Korisničko ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Lozinka: ");
            string lozinka = Console.ReadLine();

            Console.WriteLine(autentifikator.PrijaviKorisnika(ime, lozinka));
            Console.ReadLine();
        }
    }
}
