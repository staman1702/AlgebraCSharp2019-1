using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_13_min_MAX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 10 prirodnih brojeva: ");
            int min = int.MaxValue;
            int max = int.MinValue;
            int a;


            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Unesite {0}. prirodni broj: ", i.ToString());
                    a = int.Parse(Console.ReadLine());

                    if (a < min)
                    {
                        min = a;
                    }

                    if (a > max)
                    {
                        max = a;
                    }

                }

                Console.WriteLine("Min = {0} \nMax = {1}", min, max);
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("NE" + ex.ToString());

            }
            Console.ReadLine();
        }
    }
}
