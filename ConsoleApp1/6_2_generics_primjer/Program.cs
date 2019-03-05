﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_generics_primjer

    {
        class Program
        {
            static void Main(string[] args)
            {
            List<int> listaBrojeva = new List<int>();
            List<bool> listaBool = new List<bool>();
            List<Osoba> listaOsoba = new List<Osoba>();

            //o1 je deklaracija a new osoba je vracanje vrijednosti tog objekta
            Osoba o1 = new Osoba();
            Osoba o2 = new Osoba();
            Osoba o3 = new Osoba();
            Osoba o4 = new Osoba();

            Console.WriteLine("Dobar dan, moje ime je " + o1.ime + ".");


            listaOsoba.Add(o1);
            listaOsoba.Add(o2);
            listaOsoba.Add(o3);
            listaOsoba.Add(o4);

            int brojdva = 2;

            //listaOsoba.Add(brojdva); CANNOT CONVERT FROM INT TO OSOBA KLAS

            listaBrojeva.Add(brojdva);

            foreach (Osoba os in listaOsoba)
            {
                Console.WriteLine("Moje ime je " + os.ime + ".");
            }


            Console.ReadLine();
            }

        }

    class Osoba
    {
        public string ime = "Ana";

    }
    }
