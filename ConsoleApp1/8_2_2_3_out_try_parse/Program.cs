using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_2_3_out_try_parse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Unesite broj:");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("a={0}", a);
            Console.ReadLine();
        }
    }
}
