using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak9.Models
{
    public class Knjižnica
    {
        public List<Knjiga> Knjige = new List<Knjiga>();
        public List<Posudba> Posudbe = new List<Posudba>();


        public Knjižnica()
        {
            Knjige.Add(new Knjiga("1", "Povratak kralja"));
            Knjige.Add(new Knjiga("2", "Rat i mir"));
            Knjige.Add(new Knjiga("3", "Ana Karenjina"));
        }


        public string PosudiKnjigu(string osoba, string isbn)
        {
            string returnMe = "";
            foreach(Knjiga item in Knjige)
            {
                if (item.ISBN == isbn)
                {
                    Posudba novaPosudba = new Posudba(osoba, item);
                    Posudbe.Add(novaPosudba);
                    returnMe = $"Osoba: {novaPosudba.Osoba}\nISBN knjige: {novaPosudba.PosudjenaKnjiga.ISBN}\nNaslov knjige: {novaPosudba.PosudjenaKnjiga.Naslov}\nDatum posudbe: {novaPosudba.Datum}";
                    break;
                }
            }
            return returnMe;
        }

    }
}
