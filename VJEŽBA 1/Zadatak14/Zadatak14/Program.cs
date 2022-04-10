using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Upišite datum rođenja (u formatu dd mmmmm yyyy): ");
            string unešeniDatum = Console.ReadLine();
            string[] datumRođenja = unešeniDatum.Split(' ');

            int danRođenja = int.Parse(datumRođenja[0]);
            string mjesecRođenja = datumRođenja[1];
            int godinaRođenja = int.Parse(datumRođenja[2]);

            string[] uneseniMjeseci = new string[] { "Siječanj", "Veljača", "Ožujak", "Travanj", "Svibanj", "Lipanj", "Srpanj", "Kolovoz", "Rujan", "Listopad", "Studeni", "Prosinac" };

            int tekucaGodina = DateTime.Now.Year;
            int tekuciMjesec = DateTime.Now.Month;
            int tekuciDan = DateTime.Now.Day;
            int brojGodina = tekucaGodina - godinaRođenja;
            int brojMjeseca = 0;

            for (int i = 0; i < uneseniMjeseci.Length; i++)
            {
                if (uneseniMjeseci[i] == mjesecRođenja)
                    brojMjeseca = i + 1;
            }

            if (brojMjeseca >= tekuciMjesec)
            {
                if (danRođenja > tekuciDan)
                    Console.WriteLine($"Dana {danRođenja}.{brojMjeseca}.{tekucaGodina} ćete napuniti {brojGodina} godine(a)!");
                else
                    Console.WriteLine($"Dana {danRođenja}.{brojMjeseca}.{tekucaGodina} ste napunili {brojGodina} godina!");
            } else
            {
                Console.WriteLine($"Dana {danRođenja}.{brojMjeseca}.{tekucaGodina} ste napunili {brojGodina} godina!");
            }
            Console.ReadLine();            
        }
    }
}
