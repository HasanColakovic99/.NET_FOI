using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VJEŽBA1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] uneseneRijeci = new string[] { "Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett", "Kilo", "Lima", "Mike", "November", "Oscar", "Papa", "Quebec", "Romeo", "Sierra", "Tango", "Uniform", "Victor", "Whiskey", "Xray", "Yankee", "Zulu" };
            Console.WriteLine("Unesite riječ: ");
            string unesenaRiječ = Console.ReadLine();
            char[] rijec = unesenaRiječ.ToArray();
            string rezultat = "";



            foreach (char c in rijec)
            {
                foreach (string s in uneseneRijeci)
                {
                    if (s.StartsWith(c.ToString()))
                    {
                        rezultat += ' ' + s;
                    }
                }
            }
            Console.WriteLine($"Vaša riječ u fonetskoj abecedi izgleda ovako: {rezultat}");



            // MOJE RJEŠENJE
            /*
            foreach (string s in uneseneRijeci)
            {
                for (int i = 0; i < rijec.Length; i++)
                {
                    if (s.StartsWith(rijec[i].ToString())){
                        rezultat += ' ' + s;
                    }
                }  
            }
            Console.WriteLine($"Vaša riječ u fonetskoj abecedi izgleda ovako: {rezultat}");
            */


            Console.ReadLine();
        }
    }
}
