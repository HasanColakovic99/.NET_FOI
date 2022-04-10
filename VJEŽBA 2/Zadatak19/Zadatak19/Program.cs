using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak19.Models;

namespace Zadatak19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataParser data = new DataParser();

            data.Parser();
            Console.ReadLine();
        }
    }
}
