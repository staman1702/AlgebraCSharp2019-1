using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_15_Ispis_unatrag
{
    class Program
    {
        static void Main(string[] args)
        {

            //try       exceptions-i nisu potrebni jerbo nema unosa ali nije lose upisati za vjezbu !!
            //{
                Console.Write("Interval [1,10] unatrag: \n");

                for (int i = 10; i >= 1; i--)
                {

                    Console.WriteLine("{0} ", i);

                }
                Console.ReadLine();
            //}

            //catch (FormatException fex)
            //{
            //    Console.WriteLine("FORMATSKA GREŠKA PRI UNOSU ! \n\n" + fex.Message);
            //    Console.ReadLine();
            //}

            //finally
            //{
            //    Console.ReadLine();
            //}

        }
    }
}
