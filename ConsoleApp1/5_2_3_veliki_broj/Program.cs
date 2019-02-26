using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_3_veliki_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molimo unesite cijeli broj: ");
            int a = int.Parse(Console.ReadLine());


            if (a >= 100)
            {
                Console.WriteLine("Unešeni broj " + a + " je velik.");

            }
            
            else
            {
                Console.WriteLine("Unešeni broj " + a + " nije velik.");
            }

            Console.ReadLine();
        }
    }
}
