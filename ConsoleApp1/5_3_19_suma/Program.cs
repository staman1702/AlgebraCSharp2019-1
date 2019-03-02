using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_19_suma
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesite prirodne brojeve koje želite zbrojiti... \n \n(za izračun pritisnite nulu <0> ).");

            int suma = 0;
            int broj = -1;

            try
            {
                while (broj != 0)
                {
                    Console.WriteLine("Pribrojnik:");
                    broj = int.Parse(Console.ReadLine());

                    suma += broj;

                }

                Console.WriteLine("Zbroj je: {0}", suma);
            }

           
            catch (FormatException fex)
            {
                Console.WriteLine("\n GREŠKA! Nije unešena pravilna numerička vrijednost. \n \n" + fex.ToString());
                

            }
            catch (Exception ex)

            {
                Console.WriteLine("\n GREŠKA! Unos je van operacijskih mogućnosti. \n \n" + ex.ToString());

            }


            finally
            {
                Console.ReadLine();
            }
            }

    }
}
