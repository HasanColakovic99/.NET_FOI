using BiraciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Glasanje
{
    public class Glasanje
    {
        public List<string> popisOIBaKojiSuGlasali;
        public string odabranaOpcija;

        public Glasanje()
        {
            popisOIBaKojiSuGlasali = new List<string>();
        }
        public bool MozeGlasati(string oib)
        {
            PopisBiraca pb = new PopisBiraca();
            bool naPopisu = pb.PostojiBirac(oib);
            if (naPopisu && NijeGlasao(oib))
            {
                return true;
            }
            else
                return false;
        }

        private bool NijeGlasao(string oib)
        {
            foreach (string item in popisOIBaKojiSuGlasali)
            {
                if (oib == item)
                    return false;
            }
            return true;
        }

        public void Glasaj(string oib, string opcija)
        {
            popisOIBaKojiSuGlasali.Add(oib);
            odabranaOpcija = opcija;
        }
    }
}
