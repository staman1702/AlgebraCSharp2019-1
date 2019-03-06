using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_1_krug_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite Opseg vašeg kruga: ");
                double O = double.Parse(Console.ReadLine());
                if (O == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nUnešeni parametar (0) ne odgovara geometrijskom liku!");
                    Console.ResetColor();

                }
                else
                {
                    Console.WriteLine("Radijus Vašeg kruga je: {0}", Radius(O));
                    Console.WriteLine("Površina Vašeg kruga je: {0}", Površina(O));
                }
            }

            
            catch (FormatException fex)
            {
                Console.WriteLine("KRIVI FORMAT...\n" + fex.ToString());
            }

            Console.ReadKey();
        }

        static double Radius(double O)
        {
            return O / (2 * Math.PI);
        }

        static double Površina(double O)
        {
            return O * O / Math.PI;
        }




    }
    
}
