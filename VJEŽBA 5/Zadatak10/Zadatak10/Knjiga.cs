using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10
{
    public class Knjiga : IPretraga
    {
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public int Izdanje { get; set; }
        public List<IPretraga> Autori { get; set; }

        public void DodajAutora (Autor autor)
        {
            foreach(Autor item in Autori)
            {
                if(item.Ime != autor.Ime || item.Prezime != autor.Prezime)
                {
                    Autori.Add(autor);
                }
                else
                {
                    throw new NotImplementedException("Ne možete unijeti tog autora jer on već postoji");
                }
            }
        }

        public void UkloniAutora(Autor autor)
        {
            foreach (Autor item in Autori)
            {
                if (item.Ime == autor.Ime && item.Prezime == autor.Prezime)
                {
                    Autori.Remove(autor);
                }
                else
                {
                    throw new NotImplementedException("Ne možete obrisati tog autora jer on ne postoji");
                }
            }
        }

        public bool Usporedi(string kljucnaRijec)
        {
            foreach(Knjiga item in Autori)
            {
                if(item.Naziv == kljucnaRijec)
                {
                    return true;
                }
            }
            return false;
        }

        public string Ispisi()
        {
            foreach(Autor item in Autori)
            {
                return $"Naziv knjige: {this.Naziv}, Godina: {this.Godina}, Izdanje: {this.Izdanje}, Ime autora: {item.Ime}, Prezime autora: {item.Prezime}";
            }
            return null;
        }
    }
}
