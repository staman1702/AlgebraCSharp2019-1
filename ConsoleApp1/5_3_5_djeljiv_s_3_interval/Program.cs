using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_5_djeljiv_s_3_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
            int a = 0, b = 0;
            Console.WriteLine("Unesite brojeve svog intervala")
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

                //try
                //{
                //if(a < b)

                for (int i = a; i < b; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("{0 }", i);
                    }
                }
            }
        
            catch (Exception ex)
            {
                Console.WriteLine("a>b" + ex.ToString());
            }

    Console.ReadLine();
        }
    }
    //    public class aveceodbException : Exception
    //    { 
    //        public aveceodbException()
    //        {

    //        }

    //        public aveceodbException(string message)
    //            : base(message)
    //        {
    //            Console.WriteLine("dodatni message klase exceptiona");
    //        }

    //        public aveceodbException(string message, Exception inner)
    //            : base(message, inner)
    //        {

    //        }
    //    }
}
