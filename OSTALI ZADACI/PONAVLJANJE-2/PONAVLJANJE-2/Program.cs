using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONAVLJANJE_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesite broj: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite potenciju: ");
            double potencija = double.Parse(Console.ReadLine());


            double rezultat = 1;


            if (potencija > 0)
            {
                for (int i = 0; i < potencija; i++)
                {
                    rezultat *= x;
                    if (i < potencija - 1)
                    {
                        Console.Write($"{x}*");
                    }
                    else
                    {
                        Console.Write(x + " = " + rezultat);
                    }
                }
            } else
            {
                x = 1 / x;
                for (int i = 0; i > potencija; i--)
                {
                    rezultat *= x;
                    if (i != potencija + 1)
                        Console.Write($"{x}*");
                    else
                        Console.Write($"{x} = {rezultat}");
                }
            }

            
            Console.ReadLine();
        }
    }
}
