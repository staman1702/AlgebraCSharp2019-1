using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2_Switch_primjer
{
    class Program
    {
        //static double SafeDivision(double x, double y);
        //{
        //    if (y == 0)
        //    { 
        //    throw new System.DivideByZeroException();
        //    }
        //  return x / y;
        //}


        static void Main(string[] args)
        {
            double a = 0, b = 0;
            string operacija = "";

            try
            {
                Console.WriteLine("Molimo unesite dva prirodna broja i operaciju");
                Console.WriteLine("1. broj: ");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("2. broj: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Operacija: ");
                operacija = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška 1:  " + ex.ToString());

            }

            finally
            {
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

                    case "/":

                        //devidebyzero
                        Console.WriteLine("kvocijent je: {0} / {1} = {2}", a, b, (a / b);
                        break;
                       
                    //    catch (DivideByZeroException dbzex)
                    //{
                    //    Console.WriteLine("GREŠKA 2:  " + dbzex.ToString());

                    //}
                    //break;

                        //catch (Exception ex2)
                        //{
                        //    Console.WriteLine("GREŠKA 2:  " + ex2.ToString());

                        //}
                        //break;

                    default:
                        Console.WriteLine("Nepoznata operacija" + operacija);

                        break;



                }
                Console.WriteLine("\n\nZa izlaz pritisnite bilo koju tipku...");
                Console.ReadLine();
           }

        }
    }
}
