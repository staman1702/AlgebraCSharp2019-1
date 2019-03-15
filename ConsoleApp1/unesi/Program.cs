using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unesi
{
    class Program
    {
        static void Main(string[] args)
        {

            int broj = -1;
            ArrayList arr = new ArrayList();
            Console.WriteLine("Unesite prirodne brojeve i završite unos sa nulom <0>:");



            while (broj != 0)
            {
                try
                {
                    broj = int.Parse(Console.ReadLine());
                    arr.Add(broj);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unesite prirodan broj!");
                }
            }

            arr.Sort(); //dodano estetski da poslaže brojeve po redu

            Console.WriteLine("\n\nBrojevi dijeljiv sa dva i tri su: ");
            foreach (int a in arr)
            {
                if (a % 2 == 0 && a % 3 == 0)
                {
                   Console.Write("{0} ", a);
                }
            }

            Console.WriteLine("\n\nBrojevi dijeljiv sa dva ali ne i sa tri su: ");
            foreach (int a in arr)
            {
                if (a % 2 == 0 && a % 3 != 0)
                {
                    
                    Console.Write("{0} ", a);
                }
            }

            Console.WriteLine("\n\nBrojevi dijeljiv sa tri ali ne i sa dva su: ");
            foreach (int a in arr)
            {
                if (a % 2 != 0 && a % 3 == 0)
                {
                   
                    Console.Write("{0} ", a);
                }
            }
            Console.WriteLine("\n\nOstali brojevi su: ");
            foreach (int a in arr)
            {
                if (a % 2 != 0 && a % 3 != 0)
                {
                    
                    Console.Write("{0} ", a);
                }
            }
                


            
            

            Console.ReadLine();
        }
    }
}
