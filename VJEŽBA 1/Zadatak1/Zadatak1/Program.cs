using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UNESITE BROJ OD 0 DO 99");
            Console.WriteLine("Unesite broj jedinica: ");
            int jedinice = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite broj desetica: ");
            int desetice = int.Parse(Console.ReadLine());
            int broj = desetice * 10 + jedinice;
            Console.WriteLine($"Rezultat iznosi: {broj*2.1}.");
            Console.ReadLine();
        }
    }
}
