using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak5.Models;

namespace Zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            string oib;
            string odabir;
            GlasackaKutija kutija = new GlasackaKutija();
            Console.WriteLine("APLIKACIJA ZA GLASANJE");
            Console.WriteLine("-----------------------");
            do
            {
                Console.WriteLine("Unesite OIB: ");
                oib = Console.ReadLine();
                Console.WriteLine("Unesite odabir [Z] = Za, [P] = Protiv, [S] = Suzdržan: ");
                odabir = Console.ReadLine();
                kutija.Glasaj(oib, odabir);
                Console.WriteLine(kutija.DohvatiRezultateGlasanj(odabir)); 
            } while (oib != "0");
        }
    }
}
