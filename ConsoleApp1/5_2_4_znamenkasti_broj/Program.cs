﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_4_znamenkasti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molimo unesite cijeli broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                a = -a;
            }

            if (a < 10)
            {
                Console.WriteLine("Unešeni broj je jednoznamenkast.");
                
            }

            else if ( a < 100 )
            {
                Console.WriteLine("Unešeni broj je dvoznamenkast.");
            }

            else if ( a <1000 )
            {
                Console.WriteLine("Unešeni broj je troznamenkast.");
            }

            else
            {
                Console.WriteLine("Unešeni broj je višeznamenkast.");
            }

            Console.ReadLine();
        }
    }
}
