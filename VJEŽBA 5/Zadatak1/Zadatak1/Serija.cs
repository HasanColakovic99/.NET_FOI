using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public class Serija : VideoSadrzaj
    {
        public List<Sezona> listaSezona = new List<Sezona>();
        public Serija(string naziv, string opis) : base (naziv, opis)
        {

        }

        public override string VratiInfo()
        {
            string returnMe = "";
            foreach(Sezona item in listaSezona)
            {
                returnMe += item.RedniBroj + " " + item.listaEpizoda.Count + "\n";   
            }
            return "Broj sezona: " + this.listaSezona.Count + "\n" + returnMe;
        }
    }
}
