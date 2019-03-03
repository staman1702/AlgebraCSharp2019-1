using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_16_potencije1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sve potencije broja 2 manje od 1000 :");

            for (int i = 1; i < 1000; i*=2)
            {
                Console.WriteLine("{0} ", i);

            }

            Console.ReadKey();
        }
    }
}
