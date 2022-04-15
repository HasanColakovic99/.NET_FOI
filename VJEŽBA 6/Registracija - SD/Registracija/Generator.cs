using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    public class Generator
    {
        public string GenerirajEmail(string ime, string prezime)
        {
            return ime.Substring(0, 1) + prezime.Substring(0, 5) + "@foi.hr";
        }

        public string GenerirajLozinku()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }
    }
}
