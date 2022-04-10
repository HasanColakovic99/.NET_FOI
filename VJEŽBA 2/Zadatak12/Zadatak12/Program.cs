using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak12.Models;

namespace Zadatak12
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailServer emailserver = new EmailServer();
            Console.WriteLine("Otvaranje email korisničkog računa: ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Unesite vaše ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Unesite vaše prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("-------------------------------------");
            emailserver.IspisKorisnickogRacuna(emailserver.KreirajKorisnickiRacun(ime, prezime));


            Console.ReadLine();
        }
    }
}
