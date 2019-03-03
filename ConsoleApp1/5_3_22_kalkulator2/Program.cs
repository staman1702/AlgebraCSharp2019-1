using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_22_kalkulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0;
            float b = 0;
            string operacija = "";
            string odgovor = "y";

            while (odgovor == "Y" || odgovor == "y")
            {
                Console.WriteLine("Unesite vaša vrijednosti dva broja: ");
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Unesite željenu računsku operaciju (+,-,*,/) : ");
                operacija = Console.ReadLine();

                switch (operacija)
                {
                    case "+":
                        Console.WriteLine("zbroj je: {0} + {1} = {2}", a, b, (a + b));
                        break;

                    case "-":
                        Console.WriteLine("razlika je: {0} - {1} = {2}", a, b, (a - b));
                        break;

                    case "*":
                        Console.WriteLine("umnožak je: {0} * {1} = {2}", a, b, (a * b));
                        break;

                    case "/":
                        Console.WriteLine("kvocijent je: {0} / {1} = {2}", a, b, (a / b));
                        break;

                    default:
                        Console.WriteLine("Nepoznata operacija" + operacija);
                        break;


                }


                Console.WriteLine("\n\nŽelite li računati ponovno? (Y/N)");
                odgovor = Console.ReadLine();
            }
        }
    }
}
