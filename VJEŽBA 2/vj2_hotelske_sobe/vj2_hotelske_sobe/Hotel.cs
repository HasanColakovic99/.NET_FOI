using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj2_hotelske_sobe
{
    public class Hotel
    {
        private List<Soba> sobe = new List<Soba>();

        public Hotel()
        {
            Soba soba;
            this.sobe.Add(soba = new Soba("10A", 3, 0));
            this.sobe.Add(soba = new Soba("10B", 1, Soba.StatusSobe.rezervirano));
            this.sobe.Add(soba = new Soba("11A", 2, 0));
            this.sobe.Add(soba = new Soba("11B", 4, 0));
            this.sobe.Add(soba = new Soba("12A", 5, 0));
            this.sobe.Add(soba = new Soba("12B", 3, Soba.StatusSobe.rezervirano));
            this.sobe.Add(soba = new Soba("13A", 1, 0));
            this.sobe.Add(soba = new Soba("13B", 2, Soba.StatusSobe.rezervirano));
        }

        public List<Soba> PronadjiSobe(int brojOsoba)
        {
            List<Soba> lista = new List<Soba>();

            foreach(Soba item in this.sobe)
            {
                if(item.status == Soba.StatusSobe.slobodno && item.kapacitet >= brojOsoba)
                {
                    lista.Add(item);
                }
            }

            return lista;
        }

        public string RezervirajSobu(string oznaka)
        {
            string obavijest = "";
            bool ima = false;
            foreach(Soba item in this.sobe)
            {
                if(item.oznaka == oznaka && item.status == Soba.StatusSobe.slobodno)
                {
                    ima = true;
                    obavijest = "Uspješno ste rezervirali sobu!";
                    item.status = Soba.StatusSobe.rezervirano;
                    break;
                }
            }
            if (!ima)
            {
                obavijest = "Soba je već rezervirana!";
            }

            return obavijest;
        } 
    }
}
