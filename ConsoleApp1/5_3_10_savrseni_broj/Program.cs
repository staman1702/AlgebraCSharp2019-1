using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_10_savrseni_broj
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesite prirodan broj: ");
            int a = int.Parse(Console.ReadLine());

            int zbrojDjelitelja = 0;

            for (int i = 1; i < a; i++)
            {

                if (a % i == 0)

                    zbrojDjelitelja += i;

            }

            if ( a == zbrojDjelitelja)
            {
                Console.WriteLine("Unešeni broj je savršen");
            }
            else
            {
                Console.WriteLine("Unešeni broj nije savršen");
            }

            Console.ReadLine();
        }
    }
}
