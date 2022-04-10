using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak18.Models;

namespace Zadatak18
{
    class Program
    {
        static void Main(string[] args)
        {
            MeteoStanica stanica = new MeteoStanica();
            Console.WriteLine(stanica.DohvatiProsjecnuTemperaturu(Senzor.JedinicaMjera.Celzijus));
            Console.ReadLine();
        }
    }
}
