using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    public class Autentifikator
    {
        RepozitorijKorisnika repozitorij = new RepozitorijKorisnika();
        UpraviteljLozinkama upravitelj = new UpraviteljLozinkama();
        public bool PrijaviKorisnika(int idKorisnika, string lozinka)
        {
            bool ima = false;
            foreach(Korisnik item in repozitorij.Korisnici)
            {
                if(item.ID == idKorisnika && upravitelj.DohvatiLozinku(idKorisnika) == lozinka)
                {
                    ima = true;
                }
            }
            return ima;
        }
    }
}
