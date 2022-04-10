using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] glavni = new string[] { "13,2", "13,6", "-", "14,8", "15,1", "-","14,2", "13,7"};
            string[] rezervni = new string[] { "286,45", "286,85", "287,25", "288,05", "288,35", "287,95", "287,45", "286,95", "287,22" };

            decimal rezultat = 0;
            decimal broj = Convert.ToDecimal(273.15);
            decimal glavni2 = 0;
            Console.WriteLine("U proteklih 24 sata su izmjerene sljedeće temperature:");
            for (int i = 0; i < glavni.Length; i++)
            {
                if (glavni[i] == "-")
                {
                    for (int j = 0; j < rezervni.Length; j++)
                    {
                        decimal rezervni2 = Decimal.Parse(rezervni[i]);
                        rezultat = rezervni2 - broj;
                        string bla = rezultat.ToString();
                        glavni[i] = bla;
                    }   
                }
                Console.WriteLine($"{glavni[i]} °C");
                glavni2 += Decimal.Parse(glavni[i]);  
            }
            decimal rješenje = glavni2 / glavni.Length;
            Console.WriteLine($"Prosječna izmjerena temperatura je: {Math.Round(rješenje, 1)} °C!");
            Console.ReadLine();
        }
    }
}
