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
            Zaposlenik Z1 = new Zaposlenik();
            Zaposlenik Z2 = new Zaposlenik();

            List<Zaposlenik> listazaposlenika = new List<Zaposlenik>();
            listazaposlenika.Add(Z1);
            listazaposlenika.Add(Z2);

            foreach (Zaposlenik item in listazaposlenika)
            {



                Console.WriteLine("unesite ime: ");
                Z1.Ime = Console.ReadLine();

                Console.WriteLine("unesite prezime: ");
                Z1.Prezime = Console.ReadLine();

                Console.WriteLine("unesite oib: ");
                Z2.OIB = Console.ReadLine();

                Console.WriteLine("unesite broj bodova: ");
                Z1.bbod = double.Parse(Console.ReadLine());

                Console.WriteLine("unesite vrijednost bodova: ");
                Z1.vbod = double.Parse(Console.ReadLine());

                Console.WriteLine("Zaposlenik {0} {1}, oib:{2} ima neto placu: {3} hrk.",
                                    Z1.Ime, Z1.Prezime, Z1.OIB, Z1.NetoP());
                Console.ReadLine();
            }
        }
    }
}
