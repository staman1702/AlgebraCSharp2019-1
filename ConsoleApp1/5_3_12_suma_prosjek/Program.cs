using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_12_suma_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite pet prirodnih brojeva: ");
            int a = 0;
            float prosjek = 0;
            for (int i = 1; i <= 5; i++)
            {
                a += int.Parse(Console.ReadLine());
                
            }

            prosjek = (float)a/5;

            Console.WriteLine("Suma brojeva je {0}, a prosjek im je {1}", a, prosjek);
                
            
            Console.ReadLine();
        }
    }
}
