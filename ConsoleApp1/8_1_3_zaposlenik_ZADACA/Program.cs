using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_3_zaposlenik_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaposlenik z1 = new Zaposlenik();

            Console.WriteLine("unesite ime: ");
            z1.ime = Console.ReadLine();

            Console.WriteLine("unesite prezime: ");
            z1.prezime = Console.ReadLine();

            Console.WriteLine("unesite oib: ");
            z1.oib = int.Parse(Console.ReadLine());

            Console.WriteLine("unesite broj bodova: ");
            z1.bbod = double.Parse(Console.ReadLine());

            Console.WriteLine("unesite vrijednost bodova: ");
            z1.vbod = double.Parse(Console.ReadLine());

            Console.WriteLine("Zaposlenik {0} {1}, oib:{2} ima neto placu: {3} hrk.", 
                                z1.ime, z1.prezime, z1.oib, z1.NetoP());
            Console.ReadLine();
        }
    }
}
