using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TU SMO MOGLI KLASE EXCEPTIONA UBACITI!
namespace custom_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace _5_3_4_faktorijel
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Unesi faktorijelu..");
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    if (a <= 0)
                    {
                        throw new Exception("BROJ NEGATIVAN");

                    }
                    if (a >= 20)
                    {
                        throw new Exception("BROJ > 20");

                    }
                    int fact = 1;

                    for (int i = a; i > 0; i--)
                    {
                        // Console.WriteLine(i);
                        fact *= i;
                    }
                    Console.WriteLine("Faktorijela je: " + fact);
                }

                catch (VeciodDvajstException ex) 
                {
                    Console.WriteLine("BROJ NEGATIVAN" + ex.ToString());
                }
                catch (NegativeNumberException ex)
                {
                    Console.WriteLine("BROJ NEGATIVAN" + ex.ToString());
                }
            }
        }


        public class NegativeNumberException : Exception //na kraju price
        {
            public NegativeNumberException()
            {

            }

            public NegativeNumberException(string message)
                : base(message)
            {
                Console.WriteLine("dodatni message klase exceptiona");
            }

            public NegativeNumberException(string message, Exception inner)
                : base(message, inner)
            {

            }
        }//BOLJE JE DA SMO SA STRANE TO URADILI UNUTAR DRUGOG NAMESPACE-a I GORE STAVILI IH U "using" GORE

        public class VeciodDvajstException : Exception
        {
            public VeciodDvajstException()
            {

            }

            public VeciodDvajstException(string message)
                : base(message)
            {

            }

            public VeciodDvajstException(string message, Exception inner)
                : base(message, inner)
            {

            }
        }

    }
}
