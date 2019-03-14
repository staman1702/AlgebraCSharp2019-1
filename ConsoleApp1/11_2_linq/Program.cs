using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businees_layer;

namespace _11_2_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik uc1 = new Ucenik("Mara", "Marić");
            Ucenik uc2 = new Ucenik("Mara", "Darić");
            Ucenik uc3 = new Ucenik("Bara", "Barić");

            List<Osoba> osobe = new List<Osoba>();
            List<Osoba> samoMare = new List<Osoba>();
            osobe.Add(uc1);
            osobe.Add(uc2);
            osobe.Add(uc3);

            

            string trazenoIme = "Mara";
            int brojacMara = 0;

            foreach (var item in osobe)
            {
                if(item.Ime == trazenoIme)
                {
                    brojacMara++;
                    //samoMare.Add(item); rucni nacin... ali nije to smisao linq-a
                    Console.WriteLine(item.Ime);
                }

                
            }

            Console.WriteLine(trazenoIme + " se pojavljuje " + brojacMara + " puta.");


            // from <alias> in collection
            samoMare =(
                                  from os
                                  in osobe
                                  where os.Ime == trazenoIme
                                  //select os).SingleOrDefault();
                                  select os).Take(2).ToList();

            foreach (var item in samoMare)
            {
                Console.WriteLine("Moje ime je " + item.Ime + " i prezivam se " +  item.prezime);
            }

            //Console.WriteLine("Našao sam osobu " + trazenoIme + " " + samoMaje.Prezime);

            Console.ReadLine();

        }
    }
}
