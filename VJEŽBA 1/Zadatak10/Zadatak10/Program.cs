using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABLICA REZULTATA");
            Console.WriteLine("---------------------------------------");

            string[] rezultatiUtakmica = new string[] { "ARG 1:1 ISL", "HRV 2:0 NIG", "ARG 0:3 HRV", "NIG 2:0 ISL", "NIG 1:2 ARG", "ISL 1:2 HRV"};

            Console.WriteLine("Upišite oznaku reprezentacije: ");
            string reprezentacija = Console.ReadLine(); // OVDJE SE NALAZI OZNAKA REPKE ČIJE REZULTATE TREBAMO ISPISATI
            
            for (int i = 0; i < rezultatiUtakmica.Length; i++)
            {
                string[] polje = rezultatiUtakmica[i].Split(' '); // OVDJE SAM ODVOJIO SAMO RAZMAK DA MI SE U POLJE SNIMI PRVO REPKA, PA REZULTAT PA DRUGA REPKA
                string rezultat = new string(polje[1].Reverse().ToArray()); // OVDJE SMO ONDA UZELI REZULTAT I URADILI REVERSE ZA SVAKI i 

                if (polje[0].Contains(reprezentacija))
                {
                    Console.WriteLine($"{polje[0]} {polje[1]} {polje[2]}");
                }

                if (polje[2].Contains(reprezentacija)){
                    Console.WriteLine($"{polje[2]} {rezultat} {polje[0]}");
                }
            }
            Console.ReadLine();
        }
    }
}
