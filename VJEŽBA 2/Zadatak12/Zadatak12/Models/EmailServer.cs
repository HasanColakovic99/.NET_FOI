using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak12.Models
{
    public class EmailServer
    {
        public KorisničkiRačun KreirajKorisnickiRacun (string ime, string prezime)
        {
            string Email;
            string Skraceniemail;
            string loz;
            EmailGenerator email = new EmailGenerator();
            Email = email.GenerirajEmail(ime, prezime);
            Skraceniemail = email.GenerirajSkraceniEmail(ime, prezime);
            Lozinka lozinka = new Lozinka();
            loz = lozinka.GenerirajLozinku(ime, prezime);
            KorisničkiRačun kr = new KorisničkiRačun(ime, prezime, Email, Skraceniemail, loz);
            return kr;
        }

        public void IspisKorisnickogRacuna(KorisničkiRačun racun)
        {
            Console.WriteLine($"Ime: {racun.Ime}\nPrezime: {racun.Prezime}\nEmail: {racun.Email}\nEmail skraćeni: {racun.SkraceniEmail}\nLozinka: {racun.Lozinka}");
        }


    }
}
