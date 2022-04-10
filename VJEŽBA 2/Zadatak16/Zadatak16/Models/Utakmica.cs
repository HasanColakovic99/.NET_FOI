using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak16.Models
{
    public class Utakmica
    {
        public Reprezentacija ReprezentacijaDomacina;
        public Reprezentacija ReprezentacijaGosta;
        public int brojZgoditakaDomacina;
        public int brojZgoditakaGosta;
        public static List<Utakmica> Utakmice = new List<Utakmica>();
        public Utakmica(Reprezentacija reprezentacijadomacina, Reprezentacija reperezentacijagosta, int brojzgoditakadomacina, int brojzgoditakagosta)
        {
            foreach (Reprezentacija item in Reprezentacija.Reprezentacije)
            {
                if (reprezentacijadomacina.Oznaka == item.Oznaka)
                {
                    this.ReprezentacijaDomacina = item;
                }
                if (reperezentacijagosta.Oznaka == item.Oznaka)
                {
                    this.ReprezentacijaGosta = item;
                }
                this.brojZgoditakaDomacina = brojzgoditakadomacina;
                this.brojZgoditakaGosta = brojzgoditakagosta;
            }
            Utakmice.Add(this);
        }

        public string GenerirajIspis()
        {
            return $"{this.ReprezentacijaDomacina.Oznaka} {brojZgoditakaDomacina}:{brojZgoditakaGosta} {this.ReprezentacijaGosta.Oznaka}";
        }
    }
}
