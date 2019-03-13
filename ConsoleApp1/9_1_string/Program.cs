using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9_1_1_znak u riječi...\n ");
            string recenica = "Danas je sunčan dan, dobar Vam dan!";
            string rijec = "dan";
            char slovo = 'n' ;

            int brojac = 0;

            for (int i = 0; i < recenica.Length; i++)
            {
                if (recenica[i] == slovo)
                {
                    brojac++;
                }
            }

            Console.WriteLine("Znak '{0}' u rečenici '{1}' se pojavljuje {2} puta", slovo, recenica, brojac);

            Console.WriteLine("\n9_1_1_riječ u rečenice...\n ");

            
            string[] nizrijeci = recenica.Split(' ', ',','!');

            brojac = 0;
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                if(nizrijeci[i].ToLower() == rijec.ToLower())
                {
                    brojac++;
                }
            }
            

            Console.WriteLine("Rijec '{0}' u rečenici '{1}' se pojavljuje {2} puta", rijec, recenica, brojac);

            Console.WriteLine("\n9_1_3_riječi_u_novi_red...\n ");

            nizrijeci = recenica.Split(' ');
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                Console.WriteLine(nizrijeci[i]);
            }

            Console.WriteLine("\n9_1_4_brojanje_rijeci...\n ");
            Console.WriteLine("Rečenica '{0}' ima '{1}' riječi", recenica, nizrijeci.Length);



            Console.ReadLine();
        }
    }
}
