﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_objekti
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Što je to nastavnik?");
            Console.WriteLine(Nastavnik.Opis());

            //instanciraj novi objekt klase Ucenik
            Ucenik ucenik1 = new Ucenik();

            //instanciraj
            Console.WriteLine("Unesite ime ucenika: ");
            ucenik1.Ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime ucenika: ");
            ucenik1.prezime = Console.ReadLine();

            Console.WriteLine("Unesite ocjenu iz matematike: ");
            ucenik1.ocjenaMatematika = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite ocjenu iz engleskog: ");
            ucenik1.ocjenaEngleski = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite ocjenu iz biologije: ");
            ucenik1.ocjenaBiologija = int.Parse(Console.ReadLine());

            Console.WriteLine("Prosjek je: " +ucenik1.Prosjek().ToString("#.##"));

            //instanciraj novi objekt klase Ucenik
            Ucenik ucenik2 = new Ucenik("Perica");

            Console.WriteLine("\nIme učenika je " + ucenik1.Ime + " i " + ucenik2.Ime);

            List<Ucenik> ucenici = new List<Ucenik>();
            ucenici.Add(ucenik1);
            ucenici.Add(ucenik2);

            //alternativni nacin unosa,addovanja
            //List<Ucenik> ucenici = new List<Ucenik> { ucenik1, ucenik2 };
           

            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }

   
}
