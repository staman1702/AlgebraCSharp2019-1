using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_5_prosti_faktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj: ");
            List<int> prosti = new List<int>();
            int a = int.Parse(Console.ReadLine());

            int fac = 2;

            while(fac<=a)
            {
                if (a % fac == 0)
                {
                    prosti.Add(fac);
                    a = a / fac;

                }
                else
                {
                    fac++;
                }
            }

            foreach (int item in prosti)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();


        }
    }
}
