using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 5_3_20_parnepar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz cijelih brojeva: \n<za prekid niza unesite nulu>");
            
            int brojParnih = 0;
            int brojNeparnih = 0;
            int a = -1;
        while (a != 0)
        {
            a = int.Parse(Console.ReadLine());

            if (a != 0)
            {

                if (a % 2 == 0)
                {
                    brojParnih++;
                }
                else
                {
                    brojNeparnih++;
                }
            }
        }
        Console.WriteLine("U vašem nizu parnih brojeva je {0}!", brojParnih);
        }
    }
}
