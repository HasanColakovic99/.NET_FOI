using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite godinu rođenja: ");
            int godinaRođenja = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite mjesec rođenja: ");
            int mjesecRođenja = int.Parse(Console.ReadLine());

            int tekucaGodina = DateTime.Now.Year;
            int tekuciMjesec = DateTime.Now.Month;
            int brojMjeseci = 0;
            int brojDana = 0;
            int brojMjeseciUGodiniRođenja = 0;

            // BROJ MJESECI I DANA ZA GODINE IZMEĐU GODINE ROĐENJA I TEKUĆE GODINE
            for (int i = godinaRođenja + 1; i < tekucaGodina; i++)
            {
                brojMjeseci += 12;
                
            }           
            // BROJ MJESECI U GODINI KAD JE ROĐEN
            brojMjeseciUGodiniRođenja = 12 - mjesecRođenja;

            // UKUPAN BROJ MJESECI (+ BROJ MJESECI U TEKUĆOJ GODINI)
            brojMjeseci = brojMjeseci + tekuciMjesec + brojMjeseciUGodiniRođenja;
            // UKUPAN BROJ DANA
            brojDana = brojMjeseci * 30;

            Console.WriteLine("Mjeseci: " + brojMjeseci);
            Console.WriteLine("Dana: " + brojDana);
            Console.ReadLine();   
        }
    }
}
