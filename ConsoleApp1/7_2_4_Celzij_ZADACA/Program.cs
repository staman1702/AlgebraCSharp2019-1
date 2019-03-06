using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_4_Celzij_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite temperaturu u °F: ");
                double F = double.Parse(Console.ReadLine());

                Console.WriteLine("{0} °F je {1} °C", F, konv(F).ToString("#.##"));
            }
            catch (FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nKRIVI FORMAT UNOSA!");
                Console.ResetColor();
                Console.WriteLine(fex.ToString());
            }
            Console.ReadLine();

        }

        static double konv(double F)
        {
            return (F - 32) * 5 / 9;
        }
    }
}
