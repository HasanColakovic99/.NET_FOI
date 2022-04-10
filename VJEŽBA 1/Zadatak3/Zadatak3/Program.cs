using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rijeciAbecede = new string[] {"Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett", "Kilo", "Lima",
            "Mike", "Novembar", "Oscar", "Papa", "Quebec", "Romeo", "Sierra", "Tango", "Unifrom", "Victor", "Whiskey", "Xray", "Yankee", "Zulu"};

            Console.WriteLine("Unesite riječ: ");
            string rijec = Console.ReadLine();

            char[] inputArray = rijec.ToArray(); // SPREMA RIJEČ U POLJE I ONDA NA OSNOVU INDEXA MOGU DOHVATIT SVAKU RIJEČ
            string rjesenje = "";
            int krivo = 0;
            foreach (char unesenoSlovo in inputArray)
            {
                foreach (string rijecIzAbecede in rijeciAbecede)
                {
                    if (rijecIzAbecede.StartsWith(unesenoSlovo.ToString()))
                    {
                        rjesenje = rjesenje + rijecIzAbecede + " ";
                    }
                    else
                    {
                        krivo++;
                    }
                }
                if (krivo == rijeciAbecede.Length)
                {
                    Console.WriteLine("Krivi unos!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.Write("Vasa rijec napisana fonetičkom abecedom izgleda ovako: " + rjesenje);

            Console.ReadLine();
        }
    }
}
