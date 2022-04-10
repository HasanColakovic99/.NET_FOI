using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak19.Models
{
    public class DataParser
    {

        public string[] Lista = new string[] { };
        public void Parser(Sensor sensorData)
        {
            
        }

        public void Ispis()
        {
            for(int i = 0; i < Lista.Length; i++)
            {
                Console.WriteLine(Lista[i]);
            }
        }
    }
}
