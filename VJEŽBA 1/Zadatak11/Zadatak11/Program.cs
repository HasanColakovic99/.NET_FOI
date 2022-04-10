using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime zaposlenika: ");
            string imeZaposlenika = Console.ReadLine();

            string[] uneseniZaposlenici = new string[] {"Ivan Ivic;8NS", "Ivan Ivic;6DS", "Ivan Ivic;4DS", "Ivan Ivic;4P", "Pero Peric;3NS", "Pero Peric;5DS"
            , "Pero Peric;7DS", "Pero Peric;4DS", "Pero Peric;3P"};
            int satnica = 150;
            double rezultat = 0;
            string satnicaSmjena = "";
            int koeficijentDS = 1;
            float koeficijentNS = 1.5f;
            int koeficijentP = 2;
            // ZA SVAKI STRING U uneseniZaposlenici
            foreach (string s in uneseniZaposlenici)
            {
                string[] polje = s.Split(';');
                // AKO STRING s ZAPOČINJE SA ZAPOSLENIKOM KOJEG SMO UNIJELI
                if (s.StartsWith(imeZaposlenika))
                {
                    satnicaSmjena = polje[1].Substring(0, 1);
                    int brojSati = int.Parse(satnicaSmjena);
                    // AKO STRING s ZAVRŠAVA SA "NS"
                    if (s.EndsWith("NS"))
                    {
                        rezultat += brojSati * koeficijentNS * satnica;                       
                    } 
                    // ILI AKO ZAVRŠAVA SA "DS"
                    else if (s.EndsWith("DS"))
                    {                       
                        rezultat += brojSati * koeficijentDS * satnica;                       
                    }
                    // ILI PAK SA "P"
                    else
                    {
                        rezultat += brojSati * koeficijentP * satnica;
                    }
                }                
            }
            Console.WriteLine($"Zaposleniku {imeZaposlenika} treba isplatiti {rezultat} kuna!");
            Console.ReadLine();
        }
    }
}
