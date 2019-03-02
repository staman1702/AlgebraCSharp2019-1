using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_6_prijestupne_god
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Popis svih prijestupnih godina od 1900. do 2007.: \n");

            for (int i = 1900; i <= 2007; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)

                    Console.Write("{0}. g \t", i);

            }
            Console.ReadLine();
        }
    }
}
