using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite Vašu godinu rođenja: ");
            int godinaRodjenja = int.Parse(Console.ReadLine());
            int tekucaGodina = DateTime.Now.Year;
            Console.WriteLine($"Imate {tekucaGodina - godinaRodjenja} godina.");
            int brojac = 0;
            for(int i = godinaRodjenja; i <= tekucaGodina; i++)
            {

                /* 
                 
                    if (DateTime.IsLeapYear(i)){
                        brojac++;
                    }
                 
                 */

                if(((i % 4 == 0) && (i % 100 != 0)) || (i % 400 == 0)){
                    brojac++;
                } 
            }
            Console.WriteLine($"Preživjeli ste {brojac} prijestupnih godina.");
            Console.ReadLine();
        }
    }
}
