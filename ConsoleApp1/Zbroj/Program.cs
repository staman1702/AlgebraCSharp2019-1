using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracija varijabli
            int x, y;

            // definicjia varijabli x i y
            x = 5;
            y = x + 3;

            // Ispis u konzulu
            Console.WriteLine("broj x je: " + x);
            Console.WriteLine("broj y je: " + y);
            Console.WriteLine("njihov zbroj je: " + (x + y));

            // Program ostaje otvoren dok ne ukucamo broj/key
            Console.ReadKey();
        }
    }
}
