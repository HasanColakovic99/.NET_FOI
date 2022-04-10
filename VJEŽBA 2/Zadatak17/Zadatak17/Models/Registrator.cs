using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak17.Models
{
    public class Registrator
    {
        Validator validator = new Validator();
        public List<Član> Clanovi = new List<Član>();
        public Registrator()
        {
            Clanovi.Add(new Član("hcolakovi@foi.hr", "1234567"));
            Clanovi.Add(new Član("fantunovi@foi.hr", "12345678"));
            Clanovi.Add(new Član("tfarkas@foi.hr", "123456789"));
        }

        private string EmailZauzet(string email, string lozinka)
        {
            string returnMe = "";
            foreach(Član item in Clanovi)
            {
                if (item.Email == email && item.Lozinka != lozinka)
                    return "Već postoji član sa navedenim emailom!";
            }
            return returnMe;
        }

        public string RegistrirajClana (string email, string lozinka)
        {
            string returnMe = "";
            foreach(Član item in Clanovi)
            {
                if (!email.Contains("@foi.hr"))
                {
                    Console.WriteLine(validator.ValidirajEmail(email));
                    break;
                }
                else if (lozinka.Length < 6 || lozinka.Length > 10)
                {
                    Console.WriteLine(validator.ValidirajLozinku(lozinka));
                    break;
                }
                else if (item.Email == email && item.Lozinka == lozinka)
                {
                    Clanovi.Add(item);
                    return returnMe = "Član je uspješno registriran";
                }
                else if (item.Email == email)
                {
                    Console.WriteLine(EmailZauzet(email, lozinka));
                }
            }
            return returnMe;
        }


    }
}
