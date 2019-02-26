using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_5_ostatak
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("unesite cijeli broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Unešeni broj " + a + " je paran.");

            }
            else
            {
                Console.WriteLine("Unešeni broj " + a + " nije paran.");

            }

            Console.ReadKey();


        }
    }
}
