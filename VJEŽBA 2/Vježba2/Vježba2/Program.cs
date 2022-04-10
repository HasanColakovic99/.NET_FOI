using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tečaj tecajevi = new Tečaj();
            KonverterValuta konverter = new KonverterValuta();
            Console.WriteLine("Unesite iznos novca za promjenu: ");
            int iznos = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite u koju valutu želite promijeniti: ");
            string valuta = Console.ReadLine();

            

            Console.WriteLine($"Datum: {DateTime.Now}\nIznos za promjenu: {iznos} HRK\nPo tečaju: 7.5\nIznosi: {konverter.Konvertiraj(valuta, iznos)})");
        }
    }
}
