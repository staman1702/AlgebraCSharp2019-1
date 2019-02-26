using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_5_u_intervalu
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Molimo unesite cijeli broj: ");
                int a = int.Parse(Console.ReadLine());


                if (a >= 100 && a <= 200)
                {
                    Console.WriteLine("Unešeni broj " + a + " je u intervalu [100,200].");

                }

                else
                {
                    Console.WriteLine("Unešeni broj " + a + " nije u intervalu [100,200].");
                }

                Console.ReadLine();
            }
    }
}
