using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobe
{

    public class Osoba
    {
        public static BindingList<Osoba> sveOsobe = new BindingList<Osoba>();

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodenja { get; set; }

        public Osoba(string ime, string prezime, DateTime datum)
        {
            if(datum > DateTime.Now)
            {
                throw new DateException("Rođeni u budućnosti??? POKUŠAJ PONOVO!");
            }
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodenja = datum;
        }
        public static BindingList<Osoba> OsobeNaDatum(DateTime datum)
        {
            BindingList<Osoba> returnMe = new BindingList<Osoba>();
            foreach (var item in sveOsobe)
            {
                if (item.DatumRodenja.Date != datum.Date)
                {
                    returnMe.Add(item);
                }
            }
            return returnMe;
        }
        public Osoba()
        {
        }
        public override string ToString()
        {
            return Ime.Substring(0, Ime.Length).ToUpper() + " " + Prezime + " (" + DatumRodenja.ToShortDateString() + ")";
        }
    }
}
