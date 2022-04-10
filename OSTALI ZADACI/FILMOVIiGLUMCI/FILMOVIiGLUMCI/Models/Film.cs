using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILMOVIiGLUMCI.Models
{
    public class Film
    {
        // ATRIBUTI KLASE FILM (javni su)
        public string Naslov;
        public int Godina;
        public static List<Film> Filmovi = new List<Film>();
        public List<Glumac> Glumci = new List<Glumac>(); // OVO JE LISTA U KOJU ĆEMO SPREMATI SVE GLUMCE

        // SADA NAM TREBA KONSTRUKTOR
        public Film(string naslov, int godina)
        {
            this.Naslov = naslov;
            this.Godina = godina;
            // NOVOSTVORENI FILM DODAMO U LISTU SVIH FILMOVA -> (Filmovi)
            Filmovi.Add(this);
        }

        // DODAJEMO U POSTOJEĆI FILM GLUMCA
        // UVJET JE DA, AKO VEĆ U TOM FILMU IMA TAJ GLUMAC, ONDA GA NE MOŽEMO DODATI
        public void DodajGlumca(Glumac glumac)
        {
            // AKO TAJ GLUMAC NE POSTOJI U GLUMCIMA
            if (!Glumci.Contains(glumac))
            {
                // DODAJ TOG GLUMCA
                Glumci.Add(glumac);
            }
        }


        // ISPIS SVIH FILMOVA I GLUMACA U TOM FILMU
        public string Ispis()
        {
            string returnMe = "";
            returnMe = this.Naslov + " - " + this.Godina.ToString() + " (";
            foreach (Glumac item in this.Glumci)
            {
                // IMENA GLUMACA ODVOJENI ZAREZIMA
                // TOM CRUISE, 
                returnMe += item.Ispis() + ", ";
            }
            returnMe += ")";
            return returnMe;
        }


    }
}
