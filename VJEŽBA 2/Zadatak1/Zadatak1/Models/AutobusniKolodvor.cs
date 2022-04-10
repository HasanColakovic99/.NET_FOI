using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Models
{
    class AutobusniKolodvor
    {
        private List<string> Linije;

        public AutobusniKolodvor()
        {
            Linije = new List<string> 
            { "Varaždin;Zagreb;80", 
                "Varaždin;Čakovec;20", 
                "Varaždin;Slavonski Brod;240", 
                "Varaždin;Krapina;40", 
                "Vraždin;Novi Marof;22", 
                "Varaždin;Koprivnica;45", 
                "Varaždin;Virovitica;100", 
                "Varaždin;Osijek;220" };
        }

        

        private double IzracunajCijenu (int udaljenost, string tipKarte)
        {
            double rezultat = 0;
            if (tipKarte == "Regularna")
            {
                rezultat = udaljenost * 1.5;
            }
            else if (tipKarte == "Studentska")
            {
                rezultat = udaljenost * 1.2;
            }
            else
            {
                rezultat = udaljenost * 2;
            }
            return rezultat;
        }

        public string KupiKartu (string polaziste, string odrediste, string tipKarte)
        {
            int udaljenost = 0;
            foreach(string item in Linije)
            {
                string[] odvojeno = item.Split(';');
                if(odvojeno[1] == odrediste)
                {
                    udaljenost = int.Parse(odvojeno[2]);
                    break;
                }
            }
            string returnMe = "";
            returnMe = "Cijena za kartu tipa " + tipKarte + ", na relaciji " + polaziste + " - " + odrediste + " iznosi: " + IzracunajCijenu(udaljenost, tipKarte);
            return returnMe;
        }
    }
}
