using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> popisKnjiga = new List<string>() { "Prstenova druzina;Dostupna", "Dvije kule;Dostupna", "Povratak kralja;Na posudbi", "Rat i mir;Dostupna", "Zlocin i kazna;Na posudbi", "Jadnici;Dostupna" };
            string naredba = "";

            
            
            string[] listaKnjiga = popisKnjiga.ToArray();

            do
            {
                Console.WriteLine("1.#status\n2.#exit");
                Console.WriteLine("Unesite naredbu: ");
                naredba = Console.ReadLine();
                if (naredba.StartsWith("#status"))
                {
                    int brojac = 0;
                    for (int i = 0; i < listaKnjiga.Length; i++)
                    {
                        string[] knjiga = listaKnjiga[i].Split(';');
                        if (knjiga[0] == naredba.Substring(8))
                        {
                            if (knjiga[1] == "Dostupna")
                            {
                                brojac++;
                                Console.WriteLine($"Knjiga {naredba.Substring(8)} je dostupna za posudbu!");
                            } else if (knjiga[1] == "Na posudbi")
                            {
                                brojac++;
                                Console.WriteLine($"Knjiga {naredba.Substring(8)} je već posuđena!");
                            }
                        }
                    }
                    if(brojac == 0)
                    {
                        Console.WriteLine($"Knjiga {naredba.Substring(8)} ne postoji u Vašoj knjižnici!");
                    }
                    brojac = 0;
                }
            } while (naredba != "#exit");           
            Console.ReadLine();
        }
    }
}
