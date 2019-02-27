using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_11_Savrseni_brojevi
{
    class Program//odustao do danjeg dok ne skuzim sta je savrseni broj!!!
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite vaš broj: \n");

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0 && !(i % 3 == 0))
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.ReadLine();
        }
    }
}
