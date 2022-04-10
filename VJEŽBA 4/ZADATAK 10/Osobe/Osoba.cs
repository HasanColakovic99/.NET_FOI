using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobe
{

    class Osoba
    {
        public static BindingList<Osoba> Osobe = new BindingList<Osoba>();

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodenja { get; set; }

        public Osoba(string ime, string prezime, DateTime datum)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodenja = DateTime.Now;
        }
        public static BindingList<Osoba> OsobeNaDatum(DateTime datum)
        {
            foreach (var item in Osobe)
            {
                if (item.DatumRodenja.Date != datum.Date)
                {
                    item.ToString();
                    Osobe.Add(item);
                }
            }
            return Osobe;
        }
        public Osoba()
        {
        }
        public override string ToString()
        {
            return Ime.Substring(0, Ime.Length -100) + " " + Prezime + " (" + DateTime.Now.ToShortDateString() + ")";
        }
    }
}
