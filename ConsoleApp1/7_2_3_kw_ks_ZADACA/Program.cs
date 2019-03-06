using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_3_kw_ks_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite kilovate: ");
                double S = double.Parse(Console.ReadLine());

                Console.WriteLine("{0} KW iznosi {1} Konjskih snaga (KS)", S, konv(S).ToString("#"));
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

        static double konv(double S)
        {
            return S / 0.745699872;
        }
    }
}

