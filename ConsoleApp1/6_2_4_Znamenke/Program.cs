using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_4_Znamenke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj: ");
            int br = int.Parse(Console.ReadLine());

            ArrayList arr = new ArrayList();

            while (br>0)
            {
                arr.Add(br % 10);
                br /= 10;
            }

            Console.WriteLine("ispis unatrag: ");

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadKey();

        }
    }
}
