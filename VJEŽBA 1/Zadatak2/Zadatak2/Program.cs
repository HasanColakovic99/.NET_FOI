using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite treći broj: ");
            int c = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % c == 0)
                {
                    Console.WriteLine(i);
                    suma += i;
                }
            }
            Console.WriteLine($"Suma iznosi: {suma}.");
            Console.ReadLine();
        }
    }
}
