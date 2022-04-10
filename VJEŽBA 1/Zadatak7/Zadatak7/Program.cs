using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> gradovi = new List<string>();
            int izbor;
            do
            {
                Console.WriteLine("Odaberite opciju\n 1. Unos podataka\n 2. Sortiranje\n 3. Ispis\n 4. Izlaz iz programa");
                izbor = int.Parse(Console.ReadLine());
                switch (izbor)
                {
                    case 1: string noviUnos = "";
                            Console.WriteLine("Unesite grad: ");
                            noviUnos = Console.ReadLine();
                            gradovi.Add(noviUnos); // UNOSIM GRAD U LISTU
                            break;
                    case 2: int sort;
                            Console.Write("Odaberite način sortiranja (0 - UZLAZNO, 1 - SILAZNO): ");
                            sort = int.Parse(Console.ReadLine());
                            gradovi.Sort(); // SORTIRA GRADOVE UZLAZNO
                            if (sort == 1)
                            {
                                gradovi.Reverse(); // SORTIRA GRADOVE SILAZNO
                            }
                            break;
                    case 3: foreach (string s in gradovi)
                            {
                                Console.WriteLine(s);
                            }
                            break;
                    default:
                            Console.WriteLine("Neispravan unos. POKUŠAJTE PONOV!");
                            break;
                }
            } while (izbor != 4);
        }
    }
}
