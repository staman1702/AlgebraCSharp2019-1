using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veci_od
{//com
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            int a = int.Parse(Console.ReadLine());
            if (a>10)
            {
                Console.WriteLine("Unešeni broj je veći od 10.");

            }
            else
            {
                Console.WriteLine("Unešeni broj je manji od 10.");

            }
            Console.ReadKey();

        }
    }
}
