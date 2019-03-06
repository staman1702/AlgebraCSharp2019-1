﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_8_Faktorijela_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite prirodni broj:" );
                int b = int.Parse(Console.ReadLine());

                if (b <= 0)
                {
                    throw new Exception("Morate unijeti pozitivan broj!!!");

                }
                if (b >= 20)
                {
                    throw new Exception("Broj je prevelik za naše mogućnosti u dimenziji <int> (2.147.483.647)");

                }

                Console.WriteLine("Faktorijel od {0} iznosi: {1}", b, fac(b));
            }
            catch (FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nKRIVI FORMAT UNOSA!");
                Console.ResetColor();
                Console.WriteLine(fex.ToString());
            }
            Console.ReadLine();

        }

        static int fac(int b)
        {
            int fact = 1;

            for (int i = b; i > 0; i--)
            {
                fact *= i;
            }
            b = fact;

            return b;
        }
    }
}
