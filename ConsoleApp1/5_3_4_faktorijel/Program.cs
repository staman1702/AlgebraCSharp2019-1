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
                if (a<=0)
                {
                    throw new Exception("Morate unijeti pozitivan broj!!!");

                }
                if (a >= 20)
                {
                    throw new Exception("Broj je prevelik za naše mogućnosti u dimenziji <int> (2.147.483.647)");

                }
                int fact = 1;

                for (int i = a; i > 0; i--)
                {
                    // Console.WriteLine(i);
                    fact *= i;
                }
                Console.WriteLine("Faktorijela je: " + fact);
            }

            catch (FormatException fex)
            {
                Console.WriteLine("\n GREŠKA, Nije unešen numerički znak: \n \n"
                    + fex.Message
                    + "\n \n"
                    + fex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n GREŠKA, generička: \n \n" + ex.Message + "\n" + ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
