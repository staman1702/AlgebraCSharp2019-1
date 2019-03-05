using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_4_znamenke_alt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj: ");
            string ulaz_broj = Console.ReadLine();
            ulaz_broj.Reverse();

            int br = int.Parse(ulaz_broj);


            Console.WriteLine("obrnuto: {0}", br);


            Console.ReadLine();

        }
    }
}
