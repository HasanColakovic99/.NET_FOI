using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak14.Models;

namespace Zadatak14
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamingServis streamingServis = new StreamingServis();
            string unos;
            do
            {
                Console.WriteLine("Želite li prijedlog filma (da/ne)?: ");
                unos = Console.ReadLine();
                Console.WriteLine(streamingServis.Ispis());
            } while (unos != "ne");
        }
    }
}
