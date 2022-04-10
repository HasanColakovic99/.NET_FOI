using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vremenskeZone = new string[] { "Santiago;-4", "Salvador;-3", "London;+0", "Zagreb;+1", "Damask;+2", "Istanbul;+3" };

            foreach (string s in vremenskeZone)
            {
                string[] vrijeme = s.Split(';');

                string grad = vrijeme[0]; // GRAD (ZA ISPIS)

                int brojSati = int.Parse(vrijeme[1]);

                string trenutnoVrijeme = DateTime.UtcNow.ToShortTimeString(); // TRENUTNO VRIJEME
                string[] poljeSat = trenutnoVrijeme.Split(':');
                int sati = int.Parse(poljeSat[0]);
                int minute = int.Parse(poljeSat[1]);



                if (brojSati != 0)
                {
                    Console.WriteLine($"Trenutno vrijeme za {grad} je: {sati + brojSati}:{minute}");
                } 
                else if (brojSati == 0)
                {
                    Console.WriteLine($"Trenutno vrijeme za {grad} je: {sati}:{minute}");
                }             
            }
            Console.ReadLine();
        }
    }
}
