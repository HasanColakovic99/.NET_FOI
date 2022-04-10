using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak3.Models;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos;
            do
            {
                Console.WriteLine("1. Dodavanje studenata i vježbi");
                Console.WriteLine("2. Ocjenjivanje studenta iz određene vježbe");
                Console.WriteLine("3. Ispis vježbi i studenata koji su radili tu vježbu");
                Console.WriteLine("4. Ispis ukupno ostvarenih bodova studenta");
                Console.WriteLine("5. Izlaz");
                Console.Write("Što želite: ");
                unos = Console.ReadLine();
                switch (unos)
                {
                    case "1":
                        {
                            Console.WriteLine("Unesite ime studenta: ");
                            string ime = Console.ReadLine();
                            Console.WriteLine("Unesite prezime studenta: ");
                            string prezime = Console.ReadLine();
                            Console.WriteLine("");
                            Student noviStudent = new Student(ime, prezime);

                            Console.WriteLine("Unesite ime vjezbe: ");
                            string imevjezbe = Console.ReadLine();
                            Vježbe novaVježba = new Vježbe(imevjezbe);
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Unesite ime vježbe: ");
                            string imeVjezbe = Console.ReadLine();
                            Vježbe traženaVježba = null;
                            foreach (Vježbe vjezbe in Vježbe.Vjezbe)
                            {
                                if (imeVjezbe.ToLower() == vjezbe.ImeVježbe.ToLower())
                                {
                                    traženaVježba = vjezbe;
                                }
                            }
                            Console.WriteLine("Unesite ime studenta: ");
                            string ime = Console.ReadLine();
                            Console.WriteLine("Unesite prezime studenta: ");
                            string prezime = Console.ReadLine();
                            Console.WriteLine("Unesite broj bodova: ");
                            int bodovi = int.Parse(Console.ReadLine());
                            Student trazeniStudent = null;
                            foreach(Student item in Student.Studenti)
                            {
                                if(item.Ime == ime)
                                {
                                    if (item.Prezime.ToLower() == prezime.ToLower())
                                    {
                                        trazeniStudent = item;
                                    }
                                }
                            }
                            Bodovi noviBodovi = new Bodovi(bodovi, trazeniStudent, traženaVježba);
                            traženaVježba.DodajStudenta(trazeniStudent);
                            Console.WriteLine("Uspješno ste dodali studenta!");
                            break;
                        }
                    case "3":
                        {
                            foreach(Vježbe item in Vježbe.Vjezbe)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine(Vježbe.KonacniIspis());
                            break;
                        }
                }
            } while (unos != "5");
        }
    }
}
