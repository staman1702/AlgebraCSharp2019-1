using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_9_cjelobrojno_dijeljenje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite broj: ");
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                {
                    Console.WriteLine("Unešeni broj " + a + " je paran.");

                }
                if (a % 2 == 1)
                {
                    Console.WriteLine("Unešeni broj " + a + " nije paran.");

                }
                if (a % 3 == 0)
                {
                    Console.WriteLine("Unešeni broj " + a + " je dijeljiv sa 3.");

                }
                else
                {
                    Console.WriteLine("Broj {0} nije dijeljiv sa 3, ostatak je {1}", a, (a % 3));
                }
            }

            catch (FormatException e)
            {
                Console.WriteLine("Provjerite je li unešen broj?" + e.ToString());
            }

            Console.ReadKey();

        }
    }
}
