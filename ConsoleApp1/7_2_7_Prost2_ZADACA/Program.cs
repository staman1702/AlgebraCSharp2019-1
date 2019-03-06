using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_7_Prost2_ZADACA
{
    class Program
    {
        static void Main(string[] args)
        {
                                   
            try
            {

                string odg = "y";
                

                while (odg == "y" || odg == "Y")
                {
                    Console.WriteLine("Unesite prirodan broj: ");
                    int a = int.Parse(Console.ReadLine());


                    if (Prost(a))
                    {
                        Console.WriteLine("Unešeni broj je prost.");

                    }
                    else
                    {
                        Console.WriteLine("Unešeni broj nije prost.");

                    }


                    Console.WriteLine("Želite li ponoviti unos? <Y/N>");
                    odg = Console.ReadLine();
                }
            }

           catch (FormatException fex)
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nKRIVI FORMAT UNOSA!");
                    Console.ResetColor();
                    Console.WriteLine(fex.ToString());
                Console.ReadLine();
            }


        }

        static bool Prost(int a)
        {
            bool primer = true;
            if (a < 0)
            {
                a = a * (-1);

            }
            if (a == 0)
            {
                primer = false;
            }
            else

            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        primer = false;
                        break;
                    }
                }

            }
            return primer;
        }
    }
}
