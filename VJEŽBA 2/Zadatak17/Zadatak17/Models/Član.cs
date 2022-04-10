using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak17.Models
{
    public class Član
    {
        public string Email;
        public string Lozinka;
        public static List<Član> Clanovi = new List<Član>();
        public Član(string email, string lozinka)
        {
            this.Email = email;
            this.Lozinka = lozinka;
            Clanovi.Add(this);
        }
    }
}
