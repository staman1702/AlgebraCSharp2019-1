using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_9_Dijelitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("unesi broj \n");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0 )
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.ReadLine();
        }
    }
}
