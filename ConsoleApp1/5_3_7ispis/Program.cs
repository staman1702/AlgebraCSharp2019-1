using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_7_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadatak Ispis \n");

            for (int i = 1; i <= 100; i++)
            {
                if (i%7==0 && !(i%3==0))
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.ReadLine();
        }
    }
}
