using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_5._2._1._2.pozitivan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Unešeni broj je pozitivan.");

            }
            else if (a < 0) 
            {
                Console.WriteLine("Unešeni broj je negativani.");
            }
            else
            {
                Console.WriteLine("Unešeni broj je jednak nuli.");

            }
            Console.ReadKey();

        }
    }
   
}
