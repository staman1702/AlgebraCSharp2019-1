﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_1_nasljedivanje
{
    class Program
    {
        static void Main(string[] args)
        {

            Ucenik uc1 = new Ucenik();
            Ucenik uc2 = new Ucenik("Anica");
            Ucenik uc3 = new Ucenik("Perica","Perić");

            uc3.PrijaviIspit(new Ispit("Engleski"));

            

            List<Ucenik> ucenici = new List<Ucenik>();
            ucenici.Add(uc1);
            ucenici.Add(uc2);
            ucenici.Add(uc3);


            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }

            //DO_Daj pilote

            Pilot pi1 = new Pilot("Ford", "Roks");
            pi1.Kategorija_a = true;
            pi1.Kategorija_c = true;
            pi1.Kategorija_x = true;
                     

            List<Pilot> piloti = new List<Pilot>();
            piloti.Add(pi1);
          

            foreach (var item in piloti)
            {
                Console.WriteLine(item);
            }



            //DO_Daj vozaće

            Vozac vo1 = new Vozac("Luka", "lukić");
            vo1.Kategorija_a = true;
            vo1.Kategorija_c = true;
           

            var a1 = new Automobil();
            a1.marka = "Mazda";

            var a2 = new Automobil();
            a2.marka = "Toyota";

            vo1.Automobili.Add(a1);
            vo1.Automobili.Add(a2);


            Vozac vo2 = new Vozac("Niko", "Bulić");
            vo2.Kategorija_b = true;
            vo2.Kategorija_c = true;

            List<Vozac> vozaci = new List<Vozac>();
            vozaci.Add(vo1);
            vozaci.Add(vo2);

            foreach (var item in vozaci)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
