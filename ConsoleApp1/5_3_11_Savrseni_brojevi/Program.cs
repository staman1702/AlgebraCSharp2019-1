using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_11_Savrseni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.Write("--ISPIS SAVRŠENIH BROJEVA U ODREĐENOM INTERVALU-- \n");

                Console.WriteLine("Unesite donju granicu svog intervala:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite gornju granicu svog intervala:");
                int b = int.Parse(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine("Donja granica intervalu mora biti manja od gornje!");
                    Console.ReadLine();
                }
                else
                {
                    for (int i = a; i <= b; i++)
                    {

                        int zbrojDjelitelja = 0;

                        for (int j = a; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                zbrojDjelitelja += j;

                            }


                        }


                        if (i == zbrojDjelitelja)
                        {
                            Console.WriteLine("{0}\t ", i);

                        }

                    }
                }
                

            }

            catch (FormatException fex)
            {
                Console.WriteLine("KRIVI UNOS!!" + fex.ToString());
            }

            finally
            {
                Console.ReadLine();
            }
            
        }
    }

   
}
