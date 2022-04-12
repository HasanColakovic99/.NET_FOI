using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    public class UpraviteljLozinkama
    {
        public List<string> Lozinke = new List<string>();

        public UpraviteljLozinkama()
        {
            Lozinke.Add("1;abc111");
            Lozinke.Add("2;abc222");
        }

        public string DohvatiLozinku(int idKorisnika)
        {
            string lozinka = "";
            foreach(string item in Lozinke)
            {
                string[] pomocnoPolje = item.Split(';');
                if(int.Parse(pomocnoPolje[0]) == idKorisnika)
                {
                    lozinka = pomocnoPolje[1];
                }
            }
            return lozinka;
        }
    }
}
