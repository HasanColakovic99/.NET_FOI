using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak6.Models;

namespace Zadatak6
{
    public class Program
    {
        static void Main(string[] args)
        {
            string naredba;
            Hotel hotel = new Hotel();
            do
            {
                Console.WriteLine("Unesite naredbu: ");
                naredba = Console.ReadLine();

                if (naredba.StartsWith("#pronadji"))
                {
                    int kapacitet = int.Parse(naredba.Substring(10));
                    List<Soba> sobe = hotel.PronadjiSobe(kapacitet);
                    foreach(Soba item in sobe)
                    {
                        Console.WriteLine($"Oznaka: {item.Oznaka}, Kapacitet: {item.Kapacitet}");
                    }
                }

                if (naredba.StartsWith("#rezerviraj"))
                {
                    string oznaka = naredba.Substring(12);
                    Console.WriteLine(hotel.RezervirajSobu(oznaka));
                }

            } while (naredba != "#exit");
            Console.ReadLine();
        }
    }
}
