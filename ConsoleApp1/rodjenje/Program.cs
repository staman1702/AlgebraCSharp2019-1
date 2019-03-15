using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rodjenje
{
    class Program
    {
        static void Main(string[] args)
        {

            Ucenik uc1 = new Ucenik("Mario","Marić",Datum(2000,11,10), 3.5);
            Ucenik uc2 = new Ucenik("dario", "baRIĆ", Datum(1995, 8, 11), 4);
            Ucenik uc3 = new Ucenik("Pero", "Perić", Datum(1992, 6, 19), 1.5);

            List<Ucenik> ucenici = new List<Ucenik>();
            ucenici.Add(uc1);
            ucenici.Add(uc2);
            ucenici.Add(uc3);

            Console.WriteLine("učeniki:");
            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

        private static DateTime Datum(int v1, int v2, int v3)
        {
            DateTime d1 = new DateTime(v1, v2, v3);
            return d1;
        }

        static void rodjendan(object sender, EventArgs e)
        {
            {
                Console.WriteLine(
                    "Danas mi je {0} rođendan!", ((Ucenik)sender).Starost);
            }
        }
    }
}
