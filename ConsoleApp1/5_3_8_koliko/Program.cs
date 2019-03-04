using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_8_koliko
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("U INTERVALU [1,1000] IMA:");
            int a = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if ( i % 7 == 0 && i % 3 != 0)
                {
                    a++;
                }
                
            }

            Console.WriteLine("{0} BROJEVA DJELJIVIH SA 7 A NE DJELJIVIH SA 3.", a);
            Console.ReadLine();
        }
    }
}
