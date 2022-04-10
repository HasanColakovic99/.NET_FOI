using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rijeciAbecede = new string[] {"Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett", "Kilo", "Lima",
            "Mike", "Novembar", "Oscar", "Papa", "Quebec", "Romeo", "Sierra", "Tango", "Uniform", "Victor", "Whiskey", "Xray", "Yankee", "Zulu"};

            Console.WriteLine("Unesite riječ koristeći fonetsku abecedu: ");
            string recenica = Console.ReadLine();
            string[] poljeRijeci = recenica.Split(' ');
            string rjesenje = "";
            foreach(string rijec in poljeRijeci)
            {
                if (!rijeciAbecede.Contains(rijec))
                {
                    Console.WriteLine("Vaš unos je kriv");
                } else
                {
                    rjesenje = rjesenje + rijec.Substring(0, 1); // VRATIT ĆE MI PRVO SLOVO SVAKE RIJEČI
                }
            }
            Console.WriteLine("Napisali ste: " + rjesenje);
            Console.ReadLine();
        }
    }
}
