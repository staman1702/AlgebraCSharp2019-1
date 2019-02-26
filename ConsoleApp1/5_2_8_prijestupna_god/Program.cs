using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_8_prijestupna_god
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("unesite godinu: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 400 == 0 || a % 4 == 0 && !(a % 100 == 0) )
            {
                Console.WriteLine("Unešena godina " + a + " je prijestupna.");

            }

            else
            {
                Console.WriteLine("Unešena godina " + a + " nije prijestupna.");

            }

            Console.ReadKey();


        }
    }
}
