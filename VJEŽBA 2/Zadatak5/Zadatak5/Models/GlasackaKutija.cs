using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5.Models
{
    public class GlasackaKutija
    {
        private List<Glas> Glasovi = new List<Glas>();

        private bool VecGlasao(string oib)
        {
            bool glasao = false;
            foreach (Glas item in this.Glasovi)
            {
                if(oib == item.OIB)
                {
                    glasao = true;
                    return glasao;
                }
            }
            return glasao;
        }


        public void Glasaj(string oib, string odabir)
        {
            if (!this.VecGlasao(oib))
            {
                if(odabir.ToLower() == "z" || odabir.ToLower() == "p" || odabir.ToLower() == "s")
                {
                    Glas glas = new Glas(oib, odabir);
                    this.Glasovi.Add(glas);
                }
            }
            else
            {
                Console.WriteLine("Korisnik sa tim OIB-om je već glasao!");
            }
        }

        public string DohvatiRezultateGlasanj(string odabir)
        {
            string returnMe = "";
            int z = 0, p = 0, s = 0;
            foreach(Glas item in Glasovi)
            {
                odabir = item.Odabir;
                switch (odabir.ToLower())
                {
                    case "z":
                        {
                            z++;
                            break;
                        }
                    case "p":
                        {
                            p++;
                            break;
                        }
                    case "s":
                        {
                            s++;
                            break;
                        }
                }
            }
            returnMe = "Rezultati glasanja: " + "ZA = " + z + ", PROTIV = " + p + ", SUZDRŽAN = " + s;
            return returnMe;
        }

    }
}
