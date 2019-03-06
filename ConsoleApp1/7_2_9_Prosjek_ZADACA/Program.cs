using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_9_Prosjek_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prosječne ocjene i završite sa <0>: ");
            int a = -1;
            while (a!=0)

            float prosjek = 0;
            for (int i = 1; i <= 5; i++)
            {
                a += int.Parse(Console.ReadLine());

            }

            prosjek = (float)a / 5;

            Console.WriteLine("Suma brojeva je {0}, a prosjek im je {1}", a, prosjek);


            Console.ReadLine();

        }
    }
}
