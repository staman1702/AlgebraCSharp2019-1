using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_2_dijeli5
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 101; i = i + 5)

            {
                if (i == 0)
                    {
                    continue;
                        }
                Console.Write("{0}, ", i);
            }
            Console.ReadLine();
        }
    }
}
