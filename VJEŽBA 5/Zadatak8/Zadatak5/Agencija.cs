using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    public class Agencija
    {
        public string Naziv { get; set; }
        public List<Zgrada> listaZgrada = new List<Zgrada>();

        public void ProdajProstor(string oznakaProstora, string kupac)
        {
            foreach(Zgrada item in listaZgrada)
            {
                foreach(Kat katovi in item.listaKatova)
                {
                    foreach(IProstor prostori in katovi.IProstori)
                    {
                        if(prostori.Oznaka == oznakaProstora && prostori.Slobodan == true)
                        {
                            prostori.Prodaj(kupac);
                        }
                    }
                }
            }
        }
    }
}
