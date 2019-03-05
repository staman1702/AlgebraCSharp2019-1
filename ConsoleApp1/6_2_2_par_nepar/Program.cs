using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_krivi_format
{
    class Program
    {
        static void Main(string[] args)
            {
                int broj = -1;
                ArrayList arr = new ArrayList();

                Console.WriteLine("Unešeno je nekoliko razlicitih tipova:");
                
                

            arr.Add(3);
            arr.Add(6);
            arr.Add(4);
            arr.Add("jedanaest");
            arr.Add(11);
            arr.Add(10);




                for (int i = 0; i < arr.Count; i++)

                {
                    try
                    {
                        Console.WriteLine(int.Parse(arr[i].ToString()));
                    }
                    
                    catch (FormatException fex)

                    {
                    Console.WriteLine("Varijabla u ovoj poziciji nije u formatu koji se moze pretvoriti u int");
                    }

                }

                


                Console.ReadLine();
            
        }
    }
}
