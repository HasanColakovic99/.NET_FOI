using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle newTriangle = new Triangle(1,1);
            String choice = "";
            List<Triangle> triangles = new List<Triangle>();
            string greška = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("UPS! " + greška);
                Console.WriteLine(newTriangle.Draw());
                Console.WriteLine("Main menu");
                Console.WriteLine("---------");
                Console.WriteLine("1. add triangle");
                Console.WriteLine("2. display all triangles");
                Console.WriteLine("x  exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            try
                            {
                                Console.Clear();
                                Console.Write("Cathetus one = ");
                                double c1 = double.Parse(Console.ReadLine());
                                Console.Write("Cathetus two = ");
                                double c2 = double.Parse(Console.ReadLine());
                                newTriangle.CathetusOne = c1;
                                newTriangle.CathetusTwo = c2;
                                Triangle test = new Triangle(c1, c2);
                                triangles.Add(newTriangle);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(newTriangle.Draw());
                                greška = "";
                                break;
                            }
                            catch (CathethusException ex)
                            {
                                greška = ex.Poruka;
                                break;
                            }
                        }
                    case "2":
                        {
                            Console.Clear();
                            foreach (var item in triangles)
                            {
                                Console.WriteLine("---------------");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(item.ToString());
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(item.Draw());
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------");
                                Console.WriteLine("");
                            }
                            
                            break;
                        }
                    case "x":
                        return;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
