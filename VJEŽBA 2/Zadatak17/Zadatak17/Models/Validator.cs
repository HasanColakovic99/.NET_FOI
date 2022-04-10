using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak17.Models
{
    public class Validator
    {
        public string ValidirajEmail (string email)
        {
            string returnMe = "";
            if (!email.Contains("@foi.hr"))
            {
                returnMe = "Email adresa je neispravnog oblika!";
            }
            return returnMe;
        }

        public string ValidirajLozinku (string lozinka)
        {
            string returnMe = "";
            if(lozinka.Length < 6 || lozinka.Length > 10)
            {
                returnMe = "Lozinka mora imati između 6 i 10 znakova!";
            }
            return returnMe;
        }
    }
}
