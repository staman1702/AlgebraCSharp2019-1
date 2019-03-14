using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_2_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1,100]:");

            //handle
            FileStream fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Create);
            FileStream fs2 = new FileStream("3or7saZarezima.txt", FileMode.Create);

            //writer
            StreamWriter sw1 = new StreamWriter(fs1);
            StreamWriter sw2 = new StreamWriter(fs2);

            
            for (int i = 0; i <= 100; i++)
            {            
            if (i % 3 == 0 || i % 7 == 0)
                {
                    sw1.WriteLine(i);
                    sw2.Write(i + ", ");
                   
                }
            }

            

            sw1.Flush();
            sw2.Flush();



            sw1.Close();
            sw2.Close();
            fs1.Close();
            fs2.Close();


            fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Open);
            StreamReader sr1 = new StreamReader(fs1);

            string procitano = sr1.ReadToEnd();

            Console.WriteLine("Ispis iz datoteke 3or7uNoviRed.txt");

            Console.WriteLine(procitano);
            
            ////////////


            fs2 = new FileStream("3or7saZarezima.txt", FileMode.Open);
            StreamReader sr2 = new StreamReader(fs2);

            string procitano2 = sr2.ReadToEnd();

            Console.WriteLine("Ispis iz datoteke 3or7saZarezima.txt");

            Console.WriteLine(procitano2);






            Console.ReadLine();


        }
    }
}
