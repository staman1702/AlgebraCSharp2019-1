using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_2_generics_par_nepar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNepar = new List<int>();
            List<int> listPar = new List<int>();
            int br;
            Console.WriteLine("Unesi deset brojeva: ");        


            for (int i = 0; i < 10; i++)
            {
                br = int.Parse(Console.ReadLine());

                if (br%2==0)

                {
                    listPar.Add(br);
                }
                else
                {
                    listNepar.Add(br);

                }
            }

            listPar.Sort();
            listNepar.Sort();

            Console.Write("\nParni: ");

            foreach (int item in listPar)
            {
                Console.Write(item + " ");
            }

            Console.Write("\n \nNeparni: ");

            foreach (int item in listNepar)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();




        }
    }
}
