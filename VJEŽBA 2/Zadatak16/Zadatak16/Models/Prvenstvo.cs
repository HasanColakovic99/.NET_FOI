using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak16.Models
{
    public class Prvenstvo
    {
        public List<Reprezentacija> Reprezentacije = new List<Reprezentacija>();
        public List<Utakmica> Utakmice = new List<Utakmica>();


        public Prvenstvo()
        {
            this.Reprezentacije = Reprezentacija.Reprezentacije;
            this.Utakmice = Utakmica.Utakmice;
        }

        public string GenerirajTablicuRezultata()
        {
            string returnMe = "";
            foreach(Utakmica item in Utakmice)
            {
                returnMe += item.GenerirajIspis() + "\n";
            }
            return returnMe;
        }



        public int Odredi_OU(Reprezentacija reprezentacija)
        {
            int brojUtakmica = 0;
            foreach(Utakmica item in Utakmice)
            {
                if (item.ReprezentacijaDomacina.Oznaka == reprezentacija.Oznaka || item.ReprezentacijaGosta.Oznaka == reprezentacija.Oznaka)
                {
                    brojUtakmica++;
                }
            }
            return brojUtakmica;
        }

        public int Odredi_POB(Reprezentacija reprezentacija)
        {
            int brojPobjeda = 0;
            foreach (Utakmica item in Utakmice)
            {
                if (item.ReprezentacijaDomacina.Oznaka == reprezentacija.Oznaka && item.brojZgoditakaDomacina > item.brojZgoditakaGosta)
                {
                    brojPobjeda++;
                }
                else if(item.ReprezentacijaGosta.Oznaka == reprezentacija.Oznaka && item.brojZgoditakaDomacina < item.brojZgoditakaGosta)
                {
                    brojPobjeda++;
                }
            }
            return brojPobjeda;
        }

        public int Odredi_NER(Reprezentacija reprezentacija)
        {
            int brojNeriješenih = 0;
            foreach(Utakmica item in Utakmice)
            {
                if ((item.ReprezentacijaDomacina.Oznaka == reprezentacija.Oznaka || item.ReprezentacijaGosta.Oznaka == reprezentacija.Oznaka) && item.brojZgoditakaDomacina == item.brojZgoditakaGosta)
                {
                    brojNeriješenih++;
                }
            }
            return brojNeriješenih;
        }

        public int Odredi_IZG(Reprezentacija reprezentacija)
        {
            int brojIzgubljenih = 0;
            foreach(Utakmica item in Utakmice)
            {
                if(item.ReprezentacijaDomacina.Oznaka == reprezentacija.Oznaka && item.brojZgoditakaDomacina < item.brojZgoditakaGosta)
                {
                    brojIzgubljenih++;
                }
                else if(item.ReprezentacijaGosta.Oznaka == reprezentacija.Oznaka && item.brojZgoditakaDomacina > item.brojZgoditakaGosta)
                {
                    brojIzgubljenih++;
                }
            }
            return brojIzgubljenih;
        }

        public int Odredi_POZ(Reprezentacija reprezentacija)
        {
            int brojGolova = 0;
            foreach(Utakmica item in Utakmice)
            {
                if(item.ReprezentacijaDomacina.Oznaka == reprezentacija.Oznaka)
                {
                    brojGolova += item.brojZgoditakaDomacina;
                }
                if(item.ReprezentacijaGosta.Oznaka == reprezentacija.Oznaka)
                {
                    brojGolova += item.brojZgoditakaGosta;
                }
            }
            return brojGolova;
        }

        public int Odredi_PRZ(Reprezentacija reprezentacija)
        {
            int brojPrimljenihGolova = 0;
            foreach(Utakmica item in Utakmice)
            {
                if(item.ReprezentacijaDomacina.Oznaka == reprezentacija.Oznaka)
                {
                    brojPrimljenihGolova += item.brojZgoditakaGosta;
                }
                else if(item.ReprezentacijaGosta.Oznaka == reprezentacija.Oznaka)
                {
                    brojPrimljenihGolova += item.brojZgoditakaDomacina;
                }
            }
            return brojPrimljenihGolova;
        }

        public int Odredi_BOD(Reprezentacija reprezentacija)
        {
            int brojBodova = 0;
            foreach(Utakmica item in Utakmice)
            {
                if(item.ReprezentacijaDomacina.Oznaka == reprezentacija.Oznaka && item.brojZgoditakaDomacina > item.brojZgoditakaGosta)
                {
                    brojBodova += 3;
                }
                else if(item.ReprezentacijaGosta.Oznaka == reprezentacija.Oznaka && item.brojZgoditakaGosta > item.brojZgoditakaDomacina)
                {
                    brojBodova += 3;
                }
                else if(item.ReprezentacijaDomacina.Oznaka == reprezentacija.Oznaka && item.brojZgoditakaDomacina == item.brojZgoditakaGosta)
                {
                    brojBodova += 1;
                }
                else if(item.ReprezentacijaGosta.Oznaka == reprezentacija.Oznaka && item.brojZgoditakaDomacina == item.brojZgoditakaGosta)
                {
                    brojBodova += 1;
                }
            }
            return brojBodova;
        }

        public string GenerirajBodovnuLjestvicu()
        {
            string returnMe = "";
            foreach (Reprezentacija item in Reprezentacije)
            {
                returnMe += $"{item.Oznaka}\t{Odredi_OU(item)}\t{Odredi_POB(item)}\t{Odredi_NER(item)}\t{Odredi_IZG(item)}\t{Odredi_POZ(item)}\t{Odredi_PRZ(item)}\t{Odredi_POZ(item)-Odredi_PRZ(item)}\t{Odredi_BOD(item)}\n";
            }
            return returnMe;
        }


    }
}
