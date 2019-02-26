using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesite prirodan broj: ");
                int a = int.Parse(Console.ReadLine());

                if (a > 0)
                {
                    Console.WriteLine("Unešeni broj je pozitivan.");

                }
                else if (a < 0)
                {
                    Console.WriteLine("Unešeni broj je negativani.");
                }
                else
                {
                    Console.WriteLine("Unešeni broj je jednak nuli.");

                }

                }
            catch (FormatException fex)
            {
                Console.WriteLine("GREŠKA, nije unešen numerički znak: "
                    + fex.Message
                    + "\n "
                    + fex.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine("GREŠKA, generička: " 
                    + ex.Message
                    + "\n"
                    + ex.ToString());

            }

            finally
            {
                Console.ReadKey();
            }

        }
    }
}
