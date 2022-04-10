using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    public class Stambeni_prostor : IProstor
    {
        public string Oznaka { get; set; }
        public Kat Kat { get; set; }
        public bool Slobodan { get; set; }
        public string NazivFirme { get; set; }
        public string Vlasnik { get; set; }
        public void Prodaj(string kupac) 
        {
            this.Slobodan = false;
            this.Vlasnik = kupac;
        }
    }
}
