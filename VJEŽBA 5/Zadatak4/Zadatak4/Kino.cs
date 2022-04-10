using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    public class Kino
    {
        public List<Dvorana> listaDvorana = new List<Dvorana>();
        public List<Projekcija> listaProjekcija = new List<Projekcija>();

        public List<Projekcija> DohvatiProjekcije (string nazivPredstave)
        {
            List<Projekcija> novaLista = new List<Projekcija>();
            foreach(Projekcija item in listaProjekcija)
            {
                if(item.Datum == DateTime.Now && item.Predstava.Naziv == nazivPredstave)
                {
                    novaLista.Add(item);
                }
            }
            return novaLista;
        }
    }
}
