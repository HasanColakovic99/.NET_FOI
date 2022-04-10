using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak18.Models
{
    public class MeteoStanica
    {
        private List<Senzor> Senzori = new List<Senzor>();

        public MeteoStanica()
        {
            Senzori.Add(new Senzor("Senzor 1", 8.4, Senzor.JedinicaMjera.Celzijus));
            Senzori.Add(new Senzor("Senzor 2", 281.5, Senzor.JedinicaMjera.Kelvin));
            Senzori.Add(new Senzor("Senzor 3", 8.9, Senzor.JedinicaMjera.Celzijus));
            Senzori.Add(new Senzor("Senzor 4", 9.1, Senzor.JedinicaMjera.Celzijus));
        }

        private double Pretvori (Senzor.JedinicaMjera izJedinice, Senzor.JedinicaMjera uJedinicu, double vrijednost)
        {
            double rezultat = 0;
            foreach(Senzor item in Senzori)
            {
                if(Senzor.JedinicaMjera.Celzijus == izJedinice && Senzor.JedinicaMjera.Kelvin == uJedinicu && item.Vrijednost == vrijednost)
                {
                    rezultat = item.Vrijednost + 273.15;
                }
                else if(Senzor.JedinicaMjera.Kelvin == izJedinice && Senzor.JedinicaMjera.Celzijus == uJedinicu && item.Vrijednost == vrijednost)
                {
                    rezultat = item.Vrijednost - 273.15;
                }
            }
            return rezultat;
        }

        public string DohvatiProsjecnuTemperaturu(Senzor.JedinicaMjera jedinicamjere)
        {
            string returnMe = "";
            Console.WriteLine("U kojoj mjernoj jedini želite izračun prosječne temperature (C/K)?: ");
            string jedinica = Console.ReadLine();

            double rezultat = 0;
            foreach (Senzor item in Senzori)
            {
                switch (jedinica)
                {
                    case "C":
                        {
                            if (item.JedinicaMjere == Senzor.JedinicaMjera.Celzijus)
                            {
                                rezultat += item.Vrijednost;
                            }
                            if (item.JedinicaMjere == Senzor.JedinicaMjera.Kelvin)
                            {
                                rezultat += Pretvori(Senzor.JedinicaMjera.Kelvin, Senzor.JedinicaMjera.Celzijus, item.Vrijednost);
                            }
                            returnMe = $"Prosječna temperatura je: {rezultat / 4} (Celzijusa)";
                            break;
                        }
                    case "K":
                        {
                            if (item.JedinicaMjere == Senzor.JedinicaMjera.Kelvin)
                            {
                                rezultat += item.Vrijednost;
                            }
                            if (item.JedinicaMjere == Senzor.JedinicaMjera.Celzijus)
                            {
                                rezultat += Pretvori(Senzor.JedinicaMjera.Celzijus, Senzor.JedinicaMjera.Kelvin, item.Vrijednost);
                            }
                            returnMe = $"Prosječna temperatura je: {rezultat / 4} (Kelvina)";
                            break;
                        }
                }
            }
            return returnMe;
        }
        
    }
}
