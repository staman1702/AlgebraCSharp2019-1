using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_6_dobar_broj_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite cijeli broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 3 == 0 || a % 5 == 0)
            {
                Console.WriteLine("Unešeni broj " + a + " je dobar.");

            }
            else
            {
                Console.WriteLine("Unešeni broj " + a + " nije dobar.");

            }

            Console.ReadKey();
        }
    }
}
