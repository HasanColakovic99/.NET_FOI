using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak4.Models;

namespace Zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            string naredba;
            do
            {
                Console.WriteLine("1. Dodavanje države i gradova");
                Console.WriteLine("2. Zapis trenutnog broja zaraženih u gradu");
                Console.WriteLine("3. Ispis stanja zaraženih u gradu kroz vrijeme");
                naredba = Console.ReadLine();
                switch (naredba)
                {
                    case "1":
                        {
                            Console.WriteLine("Unesite ime države: ");
                            string drzava = Console.ReadLine();
                            Država noviDrazava = new Država(drzava);

                            Console.WriteLine("Unesite ime grada: ");
                            string grad = Console.ReadLine();
                            Grad noviGrad = new Grad(grad);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Unesite ime države: ");
                            string drzava = Console.ReadLine();
                            Država trazenaDrzava = null;
                            foreach(Država item in Država.Drzave)
                            {
                                if(drzava.ToLower() == item.ImeDrzave.ToLower())
                                {
                                    trazenaDrzava = item;
                                }
                            }
                            Console.WriteLine("Unesite ime grada: ");
                            string grad = Console.ReadLine();
                            Console.WriteLine("Unesite broj zaraženih: ");
                            int brojZarazenih = int.Parse(Console.ReadLine());
                            Grad trazeniGrad = null;
                            foreach(Grad item2 in Grad.Gradovi)
                            {
                                if(grad.ToLower() == item2.ImeGrada.ToLower())
                                {
                                    trazeniGrad = item2;
                                }
                            }
                            BrojZaraženih noviZarazeni = new BrojZaraženih(brojZarazenih, trazeniGrad, trazenaDrzava);
                            trazenaDrzava.DodajGrad(trazeniGrad);
                            Console.WriteLine("Uspješno ste dodali grad!");
                            break;
                        }
                    case "3":
                        {
                            foreach(Država item in Država.Drzave)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine(Država.KonacniIspis());
                            break;
                        }
                        
                }
            } while (naredba != "5");
        }
    }
}
