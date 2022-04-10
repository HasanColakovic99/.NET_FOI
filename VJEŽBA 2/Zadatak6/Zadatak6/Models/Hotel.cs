using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6.Models
{
    public class Hotel
    {
        private List<Soba> Sobe = new List<Soba>();

        public Hotel()
        {
            Sobe.Add(new Soba("10A", 3, Soba.StatusSobe.slobodna));
            Sobe.Add(new Soba("10B", 1, Soba.StatusSobe.rezervirana));
            Sobe.Add(new Soba("11A", 2, Soba.StatusSobe.slobodna));
            Sobe.Add(new Soba("11B", 4, Soba.StatusSobe.slobodna));
            Sobe.Add(new Soba("12A", 5, Soba.StatusSobe.slobodna));
            Sobe.Add(new Soba("12B", 3, Soba.StatusSobe.rezervirana));
            Sobe.Add(new Soba("13A", 1, Soba.StatusSobe.slobodna));
            Sobe.Add(new Soba("13B", 2, Soba.StatusSobe.rezervirana));
        }


        // DODAJEMO SVE ONE SOBE KOJE SU SLOBODNE I ČIJI JE KAPACITET VEĆI OD BROJA OSOBA
        public List<Soba> PronadjiSobe(int brojOsoba)
        {
            List<Soba> lista = new List<Soba>();
            foreach(Soba item in Sobe)
            {
                if(item.Status == Soba.StatusSobe.slobodna && item.Kapacitet >= brojOsoba)
                {
                    lista.Add(item);
                }
            }
            return lista;
        }


        public string RezervirajSobu(string oznaka)
        {
            bool rezervirana = false;
            foreach(Soba item in this.Sobe)
            {
                if(item.Oznaka == oznaka && item.Status == Soba.StatusSobe.slobodna)
                {
                    Console.WriteLine("Uspješno ste rezervirali sobu!");
                    item.Status = Soba.StatusSobe.rezervirana;
                    rezervirana = true;
                }
            }
            if (rezervirana == false)
            {
                Console.WriteLine("Soba je rezervirana!");
            }
            return null;
        }

    }
}
