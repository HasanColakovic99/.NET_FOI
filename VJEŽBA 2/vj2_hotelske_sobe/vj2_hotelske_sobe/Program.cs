using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj2_hotelske_sobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naredba;
            Hotel hotel = new Hotel();

            do
            {
                Console.WriteLine("Unesite naredbu: ");
                naredba = Console.ReadLine();
                string[] strArr = new string[2];
                strArr = naredba.Split(' ');
                switch (strArr[0])
                {
                    case "#pronadji":
                        {
                            int kapacitet = int.Parse(strArr[1]);
                            List<Soba> sobe = hotel.PronadjiSobe(kapacitet);
                            foreach(Soba item in sobe)
                            {
                                Console.WriteLine($"Oznaka: {item.oznaka}, Kapacitet: {item.kapacitet}");
                            }
                            break;
                        }
                    case "#rezerviraj":
                        {
                            string oznaka = strArr[1];
                            Console.WriteLine(hotel.RezervirajSobu(oznaka));
                            break;
                        }
                }

            } while (naredba != "#exit");
        }
    }
}
