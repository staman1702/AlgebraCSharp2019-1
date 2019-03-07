using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_2_Automobil_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Automobil automobil1 = new Automobil();

            Console.WriteLine("Unesite marku automobila:");
            automobil1.marka = Console.ReadLine();

            Console.WriteLine("Unesite konjske snage:");
            automobil1.ks = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite osnovnu cijenu:");
            automobil1.oscijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Cijena sa porezom za vaš automobil je: {0}", automobil1.mpc().ToString("#.##"));
            Console.ReadLine();

        }

        
    }
}
