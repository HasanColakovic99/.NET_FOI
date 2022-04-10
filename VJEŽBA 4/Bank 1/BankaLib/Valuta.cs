using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class Valuta
    {
        public string Oznaka { get; set; }
        public string Zemlja { get; set; }

        public override string ToString()
        {
            return $"{Oznaka} ({Zemlja})";
        }
    }
}
