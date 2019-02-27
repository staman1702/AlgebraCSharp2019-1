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

            catch (Exception ex) //antibiotik za sve greške, ne daje direktnu dijagnozu greške nego samo ukaže da postoji
            { 
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
