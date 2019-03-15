using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodni broj: ");
            int broj = int.Parse(Console.ReadLine());

            
            int x = broj;
            int naopako = 0;
            while (x > 0)
            {
                broj = x % 10;
                naopako = naopako * 10 + broj;
                x = x / 10;  
            }

            Console.WriteLine(naopako);
            Console.ReadKey();
        }
       
    }
}
