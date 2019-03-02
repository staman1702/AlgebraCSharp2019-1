using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_17_potencije
{
    class Program
    {
        static void Main(string[] args)
        {
            //mala izmjena, umjesto potencije 2 koristio sam potenciju 3 da vidim jel radi...
            Console.Write("Ispis od prve do desete potencije broja tri: \n");
            int b = 1;

           
                for (int i = 1; i <= 10; i++)
                {

                    Console.WriteLine("{0}. {1} ", i, (b *= 3));

                }

         
            Console.ReadLine();
        }
    }
 }
