using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_7_dobar_broj_2
{
    class Program
    {
        static void Main(string[] args)

        {
            int a = 0;
            Console.WriteLine("unesite cijeli broj: ");

            try
            {
                a = int.Parse(Console.ReadLine());

                if (a % 4 == 0 && a >= 100)
                {
                    Console.WriteLine("Unešeni broj " + a + " je dobar.");

                }
                else
                {
                    Console.WriteLine("Unešeni broj " + a + " nije dobar.");

                }
            }
            catch (FormatException e)
            {

                Console.WriteLine("Provjeri je li unešen broj! " + e.ToString());
            }


            Console.ReadKey();
        }
    }
}
