using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil au1 = new Automobil("Fiat", 2000, 5000.75);
            Automobil au2 = new Automobil("Mercedes", 2018, 150000.30);

            List<Automobil> auti = new List<Automobil>();

            auti.Add(au1);
            auti.Add(au2);

            foreach (var item in auti)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }
    }
}
