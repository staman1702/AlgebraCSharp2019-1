using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_3_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            int br = -1;

            Console.WriteLine("Unesite svoje brojeve i završite unos sa nulom: ");

            while (br!=0)

            {
                br = int.Parse(Console.ReadLine());
                lista.Add(br);

            }

            lista.Sort();
            Console.WriteLine("Vaši brojevi po redu idu: ");
                        
         
                foreach (int item in lista)
                {
                    Console.Write(item + ", ");
                }
          
            Console.ReadKey();

        }
    }
}
