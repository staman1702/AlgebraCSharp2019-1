using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_1_neparni_do_20
{
    class Program
    {//MOJ PRIMJER:
        //static void Main(string[] args)
        //{
        //    for (int i = 1; i < 21; i= i + 2)

        //    {
        //        Console.Write("{0}, ", i);
        //    }
        //    Console.ReadLine();
        //}


            //PO KNJIZI
        static void Main(string[] args)
        {
            for (int i = 2; i <= 20; i++)
            {
                if (i % 2 != 0)

                {
                    Console.Write("{0}, ", i);
                }
            }
            Console.ReadLine();
        }
    }

}
