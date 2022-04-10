using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TABLICA REZULTAT");
            Console.WriteLine("------------------------------------------------");
            string[] rezultatiUtakmica = new string[] { "HRV 2:0 NIG", "HRV 3:0 ARG", "HRV 2:1 ISL", "HRV 1:1 DAN", "HRV 2:2 RUS", "HRV 2:1 ENG", "HRV 2:4 FRA" };

            int pobjeda = 0;
            int remi = 0;
            int poraz = 0;
            foreach (string s in rezultatiUtakmica)
            {
                string[] poljeRezultata = s.Split(' ', ':');

                
                int hrv = int.Parse(poljeRezultata[1]);
                int drugiTimovi = int.Parse(poljeRezultata[2]);

                if (hrv > drugiTimovi)
                    pobjeda++;
                else if (hrv == drugiTimovi)
                    remi++;
                else
                    poraz++;

            }
            Console.WriteLine($"Ukupno ostvarenih pobjeda: {pobjeda}");
            Console.WriteLine($"Ukupno ostvarenih poraza: {poraz}");
            Console.WriteLine($"Ukupno ostvarenih remija: {remi}");
            Console.ReadLine();
        }
    }
}
