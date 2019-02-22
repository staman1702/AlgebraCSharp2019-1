using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbroj_razlika
{       //comment: dodali smo varijablu "a" izvan main-a... ona je sada vani i ne sudjeluje u izvrsavanju programa.
        //kako je dodati u main? NEMOJMO TO RADITI, NE ZNAM KAKO IZVEST TJ dodamo nakon Maina slijedece:
    // .... Program xx = new Program();
    class Program
    {
        private int a = 5559;

        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine(@"Unesite 1. broj:\n.\no i\n\t\t ..\t. ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite 2. broj: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj je: {0}", a + b);

            Console.WriteLine("Razlika je: {0}", a - b);

            Console.WriteLine("Zbroj je: {0}, razlika je: {1}", a + b, a - b); //nula prva radnje, jedinica druga etc

            Console.WriteLine("Umnožak je: {0}, kvocijent je: {1}", a * b, (decimal)a / (decimal)b); //moze i float!

            Console.WriteLine("Pritisnite tipku za izlaz...");


            Console.ReadLine();

        }
    }
}
