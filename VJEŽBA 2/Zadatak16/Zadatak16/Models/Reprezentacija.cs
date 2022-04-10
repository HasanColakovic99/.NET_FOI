using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak16.Models
{
    public class Reprezentacija
    {
        public string Oznaka;
        public string NazivRepke;
        public static List<Reprezentacija> Reprezentacije = new List<Reprezentacija>();

        public Reprezentacija()
        {
        }
        public Reprezentacija(string oznaka, string nazivRepke)
        {
            this.Oznaka = oznaka;
            this.NazivRepke = nazivRepke;
            bool ima = false;
            foreach(Reprezentacija item in Reprezentacije)
            {
                if (item.Oznaka == oznaka && item.NazivRepke == nazivRepke)
                {
                    ima = true;
                }
            }
            if (!ima)
            {
                Reprezentacije.Add(this);
            }
        }
    }
}
