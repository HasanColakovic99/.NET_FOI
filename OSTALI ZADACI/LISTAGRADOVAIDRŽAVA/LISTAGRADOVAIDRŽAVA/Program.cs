using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAGRADOVAIDRŽAVA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Države = new List<string>() { };
            List<string> Gradovi = new List<string>() { };

            int naredba;
            do
            {
                Console.WriteLine("1. Unesite državu");
                Console.WriteLine("2. Unesite grad");
                Console.WriteLine("3. Ispis kombinacija");
                Console.WriteLine("4. Izlaz iz programa");
                Console.WriteLine("Unesite broj: ");
                naredba = int.Parse(Console.ReadLine());
                switch (naredba)
                {
                    case 1:
                        Console.WriteLine("Unesite državu: ");
                        string unesenaDrzava = Console.ReadLine();
                        Države.Add(unesenaDrzava);
                        break;
                    case 2:
                        Console.WriteLine("Unesite grad: ");
                        string uneseniGrad = Console.ReadLine();
                        Gradovi.Add(uneseniGrad);
                        break;
                    case 3:
                        for (int i = 0; i < Države.Count; i++)
                        {
                            string[] drzave = Države.ToArray();
                            for (int j = 0; j < Gradovi.Count; j++)
                            {
                                string[] gradovi = Gradovi.ToArray();
                                if (drzave[i].Substring(0,1) == gradovi[j].Substring(0, 1))
                                {
                                    Console.WriteLine($"{drzave[i].Substring(2)} - {gradovi[j].Substring(2)}");
                                    break;
                                }
                            }
                        }
                        break;
                }

            } while (naredba != 4);
            Console.ReadLine();
        }
    }
}
