using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite bilo koji datum (u formatu dd mmmm): ");
            string uneseniDatum = Console.ReadLine();
            string[] datum = uneseniDatum.Split(' ');

            // DAN
            int dan = int.Parse(datum[0]);
            // MJESEC
            string mjesec = datum[1];

            // SVI MJESECI
            string[] uneseniMjeseci = new string[] { "siječanj", "veljača", "ožujak", "travanj", "svibanj", "lipanj", "srpanj", "kolovoz", "rujan", "listopad", "studeni", "prosinac" };

            switch (mjesec)
            {
                case "siječanj":
                    Console.WriteLine("Zima");
                    break;

                case "veljača":
                    Console.WriteLine("Zima");
                    break;

                case "ožujak":
                    if (dan > 20)
                        Console.WriteLine("Proljeće");
                    else
                        Console.WriteLine("Zima");
                    break;

                case "travanj":
                    Console.WriteLine("Proljeće");
                    break;

                case "svibanj":
                    Console.WriteLine("Proljeće");
                    break;

                case "lipanj":
                    if (dan > 20)
                        Console.WriteLine("Ljeto");
                    else
                        Console.WriteLine("Proljeće");
                    break;

                case "srpanj":
                    Console.WriteLine("Ljeto");
                    break;

                case "kolovoz":
                    Console.WriteLine("Ljeto");
                    break;

                case "rujan":
                    if (dan > 22)
                        Console.WriteLine("Jesen");
                    else
                        Console.WriteLine("Ljeto");
                    break;

                case "listopad":
                    Console.WriteLine("Jesen");
                    break;

                case "studeni":
                    Console.WriteLine("Jesen");
                    break;

                case "prosinac":
                    if (dan > 20)
                        Console.WriteLine("Zima");
                    else
                        Console.WriteLine("Jesen");
                    break;
            }
            Console.ReadLine();
        


            // DRUGI NAČIN RJEŠAVANJA ZADATKA
            /*
            int brojMjeseci = 0;

            // SVE DOK JE i MANJE OD BROJA ELEMENATA U POLJU uneseniMjeseci
            for(int i = 0; i < uneseniMjeseci.Length; i++)
            {
                // AKO SE NEKI MJESEC IZ uneseniMjeseci PODUDARA SA UNESENIM MJESECOM
                if (uneseniMjeseci[i] == mjesec)
                {
                    // ONDA ĆE BROJ MJESECA BITI JEDNAK INDEKSU i PLUS 1 JER POLJE KREĆE SA BROJEM 0
                    brojMjeseci = i + 1;
                }
            }

            // SADA JOŠ MORAMO POSTAVITI UVJET KADA JE PROLJEĆE, LJETO, JESEN ILI ZIMA
            if ((brojMjeseci > 3 && brojMjeseci < 6) || (brojMjeseci == 3 && dan > 20) || (brojMjeseci == 6 && dan < 21)) {
                Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu proljeće.");
            }

            if ((brojMjeseci > 6 && brojMjeseci < 9) || (brojMjeseci == 6 && dan > 20) || (brojMjeseci == 9 && dan < 23))
            {
                Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu ljeto.");
            }

            if ((brojMjeseci > 9 && brojMjeseci < 12) || (brojMjeseci == 9 && dan > 22) || (brojMjeseci == 12 && dan < 21))
            {
                Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu jesen.");
            }

            if ((brojMjeseci > 12 && brojMjeseci < 3) || (brojMjeseci == 12 && dan > 20) || (brojMjeseci == 3 && dan < 21))
            {
                Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu zima.");
            }

            Console.ReadLine();
            */
        }
    }
}
