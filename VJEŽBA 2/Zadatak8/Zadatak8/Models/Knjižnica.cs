using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8.Models
{
    public class Knjižnica
    {
        public List<Knjiga> PopisKnjiga = new List<Knjiga>();

        public Knjižnica()
        {
            PopisKnjiga.Add(new Knjiga("Prstenova druzina"));
            PopisKnjiga.Add(new Knjiga("Dvije kule"));
            PopisKnjiga.Add(new Knjiga("Povratak kralja"));
            PopisKnjiga.Add(new Knjiga("Ana Karenjina"));
            PopisKnjiga.Add(new Knjiga("Zlocin i kazna"));
            PopisKnjiga.Add(new Knjiga("Rat i mir"));
            PopisKnjiga.Add(new Knjiga("Jadnici"));
        }


        public string Posudi (string naslov, string osoba)
        {
            string returnMe = "";
            bool ima = false;
            foreach(Knjiga knjiga in this.PopisKnjiga)
            {
                if(knjiga.Naslov == naslov && knjiga.Dostupno == true)
                {
                    knjiga.Dostupno = false;
                    knjiga.Osoba = osoba;
                    returnMe = "Knjiga je uspješno posuđena!";
                    ima = true;
                    break;
                }
            }
            if (!ima)
            {
                returnMe = "Knjiga nije dostupna ili je nema na popisu!";
            }
            return returnMe;
        }


        public void Ispis()
        {
            foreach(Knjiga item in this.PopisKnjiga)
            {
                string opis = item.DohvatiOpis();
                Console.WriteLine(opis);
            }
        }


    }
}
