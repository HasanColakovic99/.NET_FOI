using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4.Models
{
    class Država
    {
        public DateTime Vrijeme;
        public string ImeDrzave;
        public static List<Država> Drzave = new List<Država>();
        public List<Grad> Gradovi = new List<Grad>();

        public Država(string imeDrzave)
        {
            this.ImeDrzave = imeDrzave;
            Drzave.Add(this);
        }

        public void DodajGrad (Grad grad)
        {
            if (!Gradovi.Contains(grad))
            {
                Gradovi.Add(grad);
            }
        }


        public string Ispis()
        {
            string returnMe = "";
            returnMe = "Ime države: " + ImeDrzave + " (";
            foreach (Grad item in this.Gradovi)
            {
                int brojZarazenih = 0;
                foreach(BrojZaraženih brzarazenih in BrojZaraženih.Zarazeni)
                {
                    if(brzarazenih.Drzava.ImeDrzave == ImeDrzave && brzarazenih.Grad.ImeGrada == item.ImeGrada)
                    {
                        brojZarazenih = brzarazenih.BrojZarazenih;
                    } 
                }
                returnMe += item.ImeGrada + " - " + brojZarazenih + ", ";
            }
            returnMe += ")";
            return returnMe;
        }

        public static string KonacniIspis()
        {
            string returnMe = "";
            foreach (Grad item in Grad.Gradovi)
            {
                int brojZarazenih = 0;
                foreach (BrojZaraženih brzarazenih in BrojZaraženih.Zarazeni)
                {
                    if (brzarazenih.Grad.ImeGrada == item.ImeGrada)
                    {
                        brojZarazenih += brzarazenih.BrojZarazenih;
                    }
                }
                returnMe += "Ime grada: " + item.ImeGrada + " - Ukupan broj zaraženih: " + brojZarazenih + " - Vrijeme: " + DateTime.Now + '\n';
            }
            return returnMe;
        }
    }
}
