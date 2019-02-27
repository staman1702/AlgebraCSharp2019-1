using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_1_1_WHILE_iz_knjige
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime = "";
            while (ime != "kraj") 
            {
                Console.WriteLine("Unesi ime: ");
                ime=Console.ReadLine();

                if(ime != "kraj")
                {
                    Console.WriteLine("Vaše ime je {0}.",ime);

                }
            }
        }
    }
}
