using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_2_prirucnik_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozdrav("Pero");
            Pozdrav("Pero", "Perić");
            Console.ReadLine();



        }

        private static void Pozdrav(string ime, string prezime)
        {
            Console.WriteLine("Dobar dan, " + ime + " " + prezime);
        }

        static void Pozdrav(string ime)
        {
            Console.WriteLine("Dobar dan, " + ime);
        }
    }
}
