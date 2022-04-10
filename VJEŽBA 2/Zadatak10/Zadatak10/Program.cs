using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak10.Models;

namespace Zadatak10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mjenjačnica mjenjačnica = new Mjenjačnica();
            do
            {
                Console.WriteLine("Unesite iznos u HRK koji želite promijeniti: ");
                double iznos = double.Parse(Console.ReadLine());
                Console.WriteLine("Unesite odredišnu valutu (EUR ili KM): ");
                string valuta = Console.ReadLine();
                mjenjačnica.IspisPotvrde(mjenjačnica.PromijeniNovac(iznos, valuta));
            } while (true);
            

            Console.ReadLine();
        }
    }
}
