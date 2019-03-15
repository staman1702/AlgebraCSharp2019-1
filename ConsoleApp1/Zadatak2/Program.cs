using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rijeci = new List<string>();

            while(true)
            {
                Console.WriteLine("Upišite rijeć: ");
                string rijec = Console.ReadLine();

                if (rijec.ToLower() == "kraj")
                { break; }
                else
                { rijeci.Add(rijec); }
            }

            List<string> rijecinaA = (from ri in rijeci
                                      where ri.First().ToString().ToLower().Contains("a")
                                      select ri).ToList();
            Console.WriteLine("\nRijeci koje počinju sa slovom a su: ");

            foreach (string rijec in rijecinaA)
            {
                Console.WriteLine(rijec + " ");
            }

            //////////////////

            List<string> rijecinaB = (from ri in rijeci
                                      where !(ri.ToLower().StartsWith(("b"))
                                      select ri).ToList();
            Console.WriteLine("\nRijeci koje počinju sa slovom b su: ");

            foreach (string rijec in rijecinaB)
            {
                Console.WriteLine(rijec + " ");
            }

            //////////////////

            List<string> rijecinaC = (from ri in rijeci
                                      where ri.First().ToString().ToLower().Contains("c")
                                      select ri).ToList();
            Console.WriteLine("\nRijeci koje počinju sa slovom C su: ");

            foreach (string rijec in rijecinaC)
            {
                Console.WriteLine(rijec + " ");
            }




            Console.ReadLine();


        }
    }
}
