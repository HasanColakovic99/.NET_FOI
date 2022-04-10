using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak9.Models
{
    public class Knjiga
    {
        public string ISBN;
        public string Naslov;

        public Knjiga(string isbn, string naslov)
        {
            this.ISBN = isbn;
            this.Naslov = naslov;
        }
    }
}
