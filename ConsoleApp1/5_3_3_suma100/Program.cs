using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_3_suma100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma prvih 100 brojeva");
            int suma = 0;

            for (int i = 0; i <= 5; i++)
            {
                suma += i;

                Console.Write("{0}, ", suma);

            }
            Console.ReadLine();
        }
    }
}
