using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_5_udaljenost_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite kordinate prve točke: ");
                Console.Write("x1:");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("y1:");
                double y1 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nUnesite kordinate druge točke: ");
                Console.Write("x2:");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("y2:");
                double y2 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nUdaljenost između zadanih točaka je {0}.", udaljenost(x1, y1, x2, y2).ToString("#.##"));
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

        static double udaljenost(double x1,double y1, double x2,double y2)
        {
            return Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        }

    }
}
