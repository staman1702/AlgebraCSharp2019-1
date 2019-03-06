using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_9_Prosjek_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Unesite prosječnu ocjenu: ");
                double a = double.Parse(Console.ReadLine());

                if (a > 1 && a < 5)

                {
                    Console.WriteLine("Prosjek je {0}", prosjek(a));

                }
                else
                {
                    Console.WriteLine("Prosjek neispravno unešen!");
                }
            }

            catch (FormatException fex)
            {
                Console.WriteLine("KRIVI FORMAT UNOSA\n" + fex.ToString());
            }
            Console.ReadLine();
        }

         static string prosjek(double a)
        {
            string prosjek = "";

            if (a<2)
            {
                prosjek = "nedovoljan";
            }
            else if (a < 2.5)
            {
                prosjek = "dovoljan";
            }
            else if (a < 3.5)
            {
                prosjek = "dobar";
            }
            else if (a < 4.5)
            {
                prosjek = "vrlo dobar";
            }
            else 
            {
                prosjek = "odličan";
            }

            return prosjek;
        }
    }
}
