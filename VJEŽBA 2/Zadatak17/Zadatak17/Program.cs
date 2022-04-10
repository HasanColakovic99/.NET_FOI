using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak17.Models;

namespace Zadatak17
{
    class Program
    {
        static void Main(string[] args)
        {
            Registrator registrator = new Registrator();
            Validator validator = new Validator();
            Console.WriteLine("Unesite email korisnika: ");
            string email = Console.ReadLine();
            Console.WriteLine("Unesite željenu lozinku: ");
            string lozinka = Console.ReadLine();
            Console.WriteLine(registrator.RegistrirajClana(email, lozinka));
            Console.ReadLine();
        }
    }
}
