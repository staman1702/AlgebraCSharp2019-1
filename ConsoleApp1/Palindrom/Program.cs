using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu: ");
            string recenica = Console.ReadLine();

            recenica = recenica.Replace(" ", "");

            string obrnuto = "";

            for (int i = recenica.Length - 1; i >= 0; i--)
            {
                obrnuto += recenica[i];
            }

            if (obrnuto == recenica)
            {
                Console.WriteLine("tekst je palindrom");
            }
            else
            {
                Console.WriteLine("tekst nije palindrom");
            }



            Console.ReadKey();
        }
            
    }
}
