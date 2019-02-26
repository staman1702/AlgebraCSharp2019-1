using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablica množenja:");
            Console.WriteLine("\n\n ");
            for (int i = 1; i < 11; i++)
            {
                for (int y = 1; y < 11; y++)
                {
                    Console.Write("{0}\t", i*y);
                }

               Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
