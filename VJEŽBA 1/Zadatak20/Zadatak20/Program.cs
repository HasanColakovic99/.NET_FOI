using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite naziv grada: ");
            string nazivGrada = Console.ReadLine();

            string[] prvoPolje = new string[] { "Santiago", "Salvadro", "London", "Zagreb", "Damask", "Istanbul" };
            string[] drugoPolje = new string[] { "UTC-4", "UTC-3", "UTC+0", "UTC+1", "UTC+2", "UTC+3" };

            string vrijeme = DateTime.UtcNow.ToShortTimeString();
            string[] vrijeme2 = vrijeme.Split(':');
            int trenutnoVrijemeSati = int.Parse(vrijeme2[0]); // 12
            int trenutnoVrijemeMinute = int.Parse(vrijeme2[1]);
            int ukupanBrojSati = 0;
            for (int i = 0; i < prvoPolje.Length; i++)
            {
                if (prvoPolje[i] == nazivGrada) { 

                    for (int j = 0; j < drugoPolje.Length; j++)
                    {
                        int broj = int.Parse(drugoPolje[i].Substring(4, 1)); // BROJ UZ UTC (BEZ - I +)
                        string znak = drugoPolje[i].Substring(3, 1);

                        if (znak == "+" && prvoPolje[i] == nazivGrada)
                        {
                            ukupanBrojSati = trenutnoVrijemeSati + broj;
                        }
                        else
                        {
                            ukupanBrojSati = trenutnoVrijemeSati - broj;
                        }
                    }
                    Console.WriteLine($"Trenutno vrijeme u gradu {prvoPolje[i]} je: {ukupanBrojSati}:{trenutnoVrijemeMinute}");
                }    
            }
            Console.ReadLine();
        }
    }
}
