using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_HE
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string operacija = "";

            try
            {
                Console.WriteLine("Unesite 1. broj: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Unesite 2. broj: ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Unestite operaciju < +,-,*,/ > ");
                operacija = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GREŠKA 1: " + ex.ToString());

            }
            finally
            {
                switch (operacija)
                {
                    case "+":
                        Console.WriteLine("Zbroj: {0} + {1} = {2} ", a, b, (a + b));
                        break;
                    case "-":
                        Console.WriteLine("Razlika: {0} - {1} = {2} ", a, b, (a - b));
                        break;
                    case "*":
                        Console.WriteLine("Umnožak: {0} * {1} = {2} ", a, b, (a * b));
                        break;
                    case "/":
                        Console.WriteLine("Kvocijent: {0} / {1} = {2}", a, b, (a / b));
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nemoguća operacija");
                        break;

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Za izlaz pritisnite tipku...");
                Console.ReadLine();

            }

        }
    }
}
