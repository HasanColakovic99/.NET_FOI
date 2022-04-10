using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10
{
    public class Autor : IPretraga
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        private string Email { get; set; }

        public Autor(string ime, string prezime, string email)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
        }

        public string Ispisi()
        {
            return $"Ime autora: {this.Ime}, Prezime autora: {this.Prezime}, Email autora: {this.Email}";
        }

        public bool Usporedi(string kljucnaRijec)
        {
            if(this.Ime == kljucnaRijec || this.Prezime == kljucnaRijec)
            {
                return true;
            }
            return false;
        }
    }
}
