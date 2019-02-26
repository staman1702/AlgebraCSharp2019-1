using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_1_1
{
    class Program
    {
        static void Main(string[] args)
        {//svi bojevi od 0 do 99
            for (int i = 0; i < 100; i++)
            {

                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n\n ");
            //svi brojevi 16,18,20... 88
            for (int i = 16; i < 88; i+=2)
            {

                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n\n ");
            //svi brojevi 135,130,125... 55
            for (int i = 135; i > 54; i = i - 5)
            {
   
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n\n ");
            //svi brojevi 0... 99 osim 80
            for (int i = 0; i < 100; i++)
            {
                if (i==80)
                {
                    continue;//nije radilo break nego nastavilo, preskocilo
                }
                                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n\n ");
            //svi brojevi 0,1,..99 PRESKOĆI VEĆE OD 80
            for (int i = 0; i < 100; i++)
            {
                if (i == 80)
                {
                    break;
                }
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n\n ");
            //svi brojevi 0,1,..9999 koji su djeljivi sa 17 i 13
            for (int i = 0; i < 10000; i++)
            {
                if (i % 17 == 0 && i % 13 == 0)
                {
                    Console.Write("{0} ", i);
                }
                
            }
            Console.WriteLine("");
            Console.ReadKey();

        }
    }
}
