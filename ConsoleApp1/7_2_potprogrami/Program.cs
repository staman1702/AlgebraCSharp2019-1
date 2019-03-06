using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_potprogrami
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld(); //pozivanje heloworlda

            //da smo van Main-a bi morali pisati " Program.HelloWorld(); "
            //npr:
            Program.HelloWorld();


            Console.WriteLine(HelloWorld("Ola")); //mjesto vracanja vrijednosti iz funkcije

            Console.ReadKey();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        static String HelloWorld(string poz)
        {
            return poz + " i tebi korisniče" ; //ovo je funkcija koja vraca neku vrijednost
        }
    }
}

<?php
    
    
 ?>