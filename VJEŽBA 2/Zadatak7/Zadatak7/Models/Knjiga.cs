using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7.Models
{
    public class Knjiga
    {
        public string ISBN;
        public string Naslov;
        public enum StatusKnjiga {Dostupno, NaPosudbi};
        public StatusKnjiga Status;
        public Knjiga(string isbn, string naslov, StatusKnjiga status)
        {
            this.ISBN = isbn;
            this.Naslov = naslov;
            this.Status = status;
        }
    }
}
