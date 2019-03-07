using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_1_Proivod_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod1 = new Proizvod();

            Console.WriteLine("Unesite naziv proizvoda:");
            proizvod1.ime = Console.ReadLine();

            Console.WriteLine("Unesite osnovnu cijenu prozvoda:");
            proizvod1.cijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite maržu (%):");
            proizvod1.marza = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite porez (%):");
            proizvod1.porez = double.Parse(Console.ReadLine());

            Console.WriteLine("Maloprodajna cijena je: {0}", proizvod1.mpc().ToString("#.##"));

            Console.ReadKey();




        }
    }
}
