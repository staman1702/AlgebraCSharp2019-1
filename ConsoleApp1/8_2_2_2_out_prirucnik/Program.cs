using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_2_2_out_prirucnik
{
    class Program
    {
        static void Main(string[] args)
        { 
            int a;
            Inicijaliziraj(out a);
            Console.WriteLine("a={0}", a);
            Console.ReadLine();
        }

        private static void Inicijaliziraj(out int a)
        {
            a = 1;
        }
    }
}
