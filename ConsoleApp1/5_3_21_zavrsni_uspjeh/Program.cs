using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_21_zavrsni_uspjeh
{
    class Program
    {
        static void Main(string[] args)
        {

            int suma = 0;
            string ocjena = "";
            bool nedovoljan = false;

            Console.WriteLine("Unesite broj predmeta za koje unosite ocjene: ");
            int brojOcjena = int.Parse(Console.ReadLine());

            for (int i = 1; i <= brojOcjena; i++)
            {
                bool unosObavljen = false;
                while (!unosObavljen)
                {
                    Console.WriteLine("Unesite {0}. ocjenu:", i);

                    ocjena = Console.ReadLine();


                if (ocjena == "1" || ocjena == "2" || ocjena == "3" || ocjena == "4" || ocjena == "5")

                        {
                        unosObavljen = true;


                        }

                        else
                        {
                            Console.WriteLine("Unos pogrešan!");

                        }
                }

                if (ocjena == "1")
                {
                    nedovoljan = true;
                    break;

                }
                else
                {
                    suma += int.Parse(ocjena);
                }

            }

            if (nedovoljan)
            {
            Console.WriteLine("Bez obzira na Vaše ostale ocjene, Vaš uspjeh nije prolazan.");

            }

            else
            {
            Console.WriteLine("Vaš prolazni prosjek je {0}.", (float)suma / brojOcjena);
            }
        
            Console.ReadKey();
        }

    }
}
