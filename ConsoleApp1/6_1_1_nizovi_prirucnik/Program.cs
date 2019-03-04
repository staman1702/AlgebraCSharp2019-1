using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_1_nizovi_prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //deklaracija u memoriji
                int?[] niz = new int?[3];

                //init
                niz[0] = 55;
                niz[2] = 77;
                niz[1] = 22;

                //niz[3] = 33; nece proci jer nije unutar niza!

                for (int i = 0; i < niz.Length; i++)
                {
                    if (niz[i] == null)
                    {
                        throw new Exception("Niz sadrži neinicijalizirane vrijednosti na indexu " + i);
                    }
                    Console.WriteLine((i + 1) + ": " + niz[i] /*+ niz[5]*/);
                }
            }
            catch(IndexOutOfRangeException ioorex)
            {
                Console.WriteLine("Pokušali ste dohvatiti nepostojeći član niza! " + ioorex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
