using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_17_potencije
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ispis od prve do desete potencije broja dva: \n");
            int b = 1;

           
                for (int i = 1; i <= 10; i++)
                {

                    Console.WriteLine("{0}. {1} ", i, (b *= 2));

                }

         
            Console.ReadLine();
        }
    }
 }
