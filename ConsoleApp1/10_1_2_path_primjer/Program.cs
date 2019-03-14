using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_2_path_primjer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mapa u kojoj se izvršava naš program: ");
            Console.WriteLine(Environment.CurrentDirectory);

            Console.WriteLine("\nPostoji li Proba.txt u izvršnoj mapi: ");

            //path klasa
            string mojaPutanja = Path.Combine(Environment.CurrentDirectory, "Proba.txt");

            //file klasa
            Console.WriteLine(File.Exists(mojaPutanja));


            //direktorij klsa
            if(!Directory.Exists("Proba"))
            {
                //ako ne postoji kreiraj!
                Directory.CreateDirectory("Proba");
            }

            //ispisujem sve foldere na D:-u
            Console.WriteLine("\nDirektoriji na D:");
            string[] sDirs = Directory.GetDirectories(@"D:\");

            foreach (string sDir in sDirs)
            {
                Console.WriteLine(sDir);
            }

            //ispisujem sve fileove na D:-u
            Console.WriteLine("\nDatoteke na D:-u ");
            string[] sFiles = Directory.GetFiles(@"D:\");
            foreach (string sFile in sFiles)
            {
                //Console.WriteLine(Path.GetFileName(sFile));

                Console.WriteLine(Path.GetFileName(sFile) + " ; " + File.GetAttributes(sFile) + "; Created: " 
                    + File.GetCreationTime(sFile));
            }

            Console.ReadLine();



        }
    }
}
