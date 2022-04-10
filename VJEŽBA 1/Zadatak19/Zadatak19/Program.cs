using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meteoStanica = new string[] { "13,2;C", "286,85;K", " ", "14,8;C", "15,1;C", "287,95;K", "14,2;C", "13,7;C" };

            decimal broj = Convert.ToDecimal(273.15);
            decimal rezultat = 1;
            for(int i = 0; i < meteoStanica.Length; i++)
            {
                if (meteoStanica[i].EndsWith("K"))
                {
                    string[] polje = meteoStanica[i].Split(';');
                    decimal kelvini = Decimal.Parse(polje[0]);
                    rezultat = kelvini - broj;
                    string bla = rezultat.ToString();
                    meteoStanica[i] = bla;
                    Console.WriteLine(i + 1 + ". ocitanje = " + meteoStanica[i].Substring(0, 4) + " °C");
                } 
                else if (meteoStanica[i] == " ")
                {
                    Console.WriteLine(i + 1 + ". ocitanje = Nije uspjelo!");
                } else
                {
                    Console.WriteLine(i + 1 + ". ocitanje = " + meteoStanica[i].Substring(0,4) + " °C");
                }
            }
            Console.ReadLine();
        }
    }
}
