using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite iznos KUNA (cijeli broj) koji želite promijeniti (u tekstualnom obliku): ");
            string unosKorisnika = Console.ReadLine();

            string[] iznosKuna = unosKorisnika.Split(' ');

            Console.WriteLine("Upišite tečaj EUR-a (u brojčanom decimalnom obliku): ");
            float tecajEura = float.Parse(Console.ReadLine());

            string[] uneseniBrojevi = new string[] { "jedan", "dva", "tri", "četiri", "pet", "šest", "sedam", "osam", "devet", "nula" };

            int[] poljeBrojeva = new int[iznosKuna.Length];

            string rez = "";
            int brojac = 0;
            foreach (string s in iznosKuna)
            {
                for (int i = 0; i < uneseniBrojevi.Length; i++)
                {
                    if (uneseniBrojevi[i] == s)
                    {
                        poljeBrojeva[brojac] = i + 1;
                    }
                }
                brojac++;
            }

            for (int i = 0; i < poljeBrojeva.Length; i++)
            {
                rez = rez + poljeBrojeva[i];
            }

            int cijeliBroj = int.Parse(rez);

            Console.WriteLine($"{cijeliBroj} KN po tečaju {tecajEura} iznosi {cijeliBroj / tecajEura} EUR.");
            Console.ReadLine();
        }
    }
}
