using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2_Switch_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string operacija = "";

            Console.WriteLine("Molimo unesite dva prirodna broja i operaciju");
            Console.WriteLine("1. broj: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("2. broj: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Operacija: ");
            operacija = Console.ReadLine();


            switch (operacija)
            {
                case "+":
                case "plus":
                    Console.WriteLine("zbroj je: {0} + {1} = {2}", a, b, (a + b));
                    break;

                case "-":
                    Console.WriteLine("razlika je: {0} - {1} = {2}", a, b, (a - b));
                    break;

                case "*":
                case "x":
                
                    Console.WriteLine("umnožak je: {0} * {1} = {2}", a, b, (a * b));
                    break;

                default:
                    Console.WriteLine("kvocijent je: {0} / {1} = {2}", a, b, (a / b));
                    break;

            }
            Console.WriteLine("\n\nZa izlaz pritisnite bilo koju tipku...");
            Console.ReadLine();
        }
    }
}
