using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_2_2_primjer_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 5 brojeva:");
            int broj;
            int[] niz = new int[5];


            for (int i = 0; i < niz.Length; i++)
            {
                broj = int.Parse(Console.ReadLine());
                niz[i] = broj;

            }

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] == niz.Max())
                {
                    ConsoleColor defaultnaboja = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" " + niz.Max());
                    Console.ForegroundColor = defaultnaboja;
                }


                else
                {
                    Console.Write(" " + niz[i]);
                }
            }



            Console.ReadLine();
        }
    }
}
