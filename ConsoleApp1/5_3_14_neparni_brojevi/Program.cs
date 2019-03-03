using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_14_neparni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispis neparnih brojeva u intervalu [1,10]: \n\n");

            for (int i = 1; i <= 10; i++)
            {
                if ( !(i%2==0) )
                {
                    Console.WriteLine("{0}", i);

                }

            }

            Console.ReadLine();

        }
    }
}
