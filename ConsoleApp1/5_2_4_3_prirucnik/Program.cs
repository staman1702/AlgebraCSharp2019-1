using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_4_3_prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime škole koju pohađate: ");
            string skola = Console.ReadLine();

            if (!(skola == "Algebra"))
            {
                Console.WriteLine("Upišite seminar u Algebri!");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("Dobar izbor!");
                Console.ReadLine();
            }
        }
    }
}
