using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djeljivo_sa_3
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("unesite cijeli broj: ");
                int a = int.Parse(Console.ReadLine());

                if (a % 3 == 0)
                {
                    Console.WriteLine("Unešeni broj " + a + " je dijeljiv sa 3.");

                }
                else
                {
                    Console.WriteLine("Unešeni broj " + a + " nije dijeljiv sa 3.");

                }

                Console.ReadKey();


            }
        }
    }
}
