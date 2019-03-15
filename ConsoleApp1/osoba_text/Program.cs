using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osoba_text
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba os1 = new Osoba("MarKo", "marULIĆ");
            Osoba os2 = new Osoba("anica", "anić");
            Osoba os3 = new Osoba("Perica", "Perić");

            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(os1);
            osobe.Add(os2);
            osobe.Add(os3);

            Console.WriteLine("------");

            foreach (var item in osobe)
                {
                Console.WriteLine("Pozdrav! " + item);
                }

            Console.ReadKey();
        }
    }
}
