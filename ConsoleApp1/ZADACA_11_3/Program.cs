using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADACA_11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ucenik ucenik1 = new Ucenik("Mario", "Marić");
            //Ucenik ucenik2 = new Ucenik("Ivan", "ivić");
            //Ucenik ucenik3 = new Ucenik("tomo", "Tomić");

            List<Ucenik> listaucenika = new List<Ucenik>()
            {
                new Ucenik("mario","Marić"),
                new Ucenik("Ivan","ivić", 456789123),
                new Ucenik("tomo","Tomić",789465132, 4562)

            };

            listaucenika.ForEach(Ucenik => UnesiOib(Ucenik));
            listaucenika.ForEach(Ucenik => UnesiRacun(Ucenik));
            listaucenika.ForEach(Ucenik => UnesiTelefon(Ucenik));


            Console.ReadKey();


            listaucenika.ForEach(Ucenik => IspisUcenika(Ucenik));

                Console.ReadLine();

            listaucenika.ForEach(Ucenik => IspisUcenika2(Ucenik));

            Console.ReadLine();
            


        }

        private static void UnesiOib(Ucenik ucenik)
        {
            // Korisnik mora ispravno unijeti oib
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite oib učenika {0}: ", ucenik.Ime);

                try
                {
                    ucenik.Oib = int.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }

                catch (FormatException ex) // specijalne greške
                {
                    Console.WriteLine("Greška:" + ex.Message);
                }
                catch (Exception ex)// ostale greške
                {
                    Console.WriteLine("Greška" + ex.Message);
                }
            }
        }

        private static void UnesiRacun(Ucenik ucenik)
        {
            // Korisnik mora ispravno unijeti racun
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite stanje racuna učenika {0}: ", ucenik.Ime);

                try
                {
                    ucenik.Racun = int.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }

                catch (FormatException ex) // specijalne greške
                {
                    Console.WriteLine("Greška:" + ex.Message);
                }
                catch (Exception ex)// ostale greške
                {
                    Console.WriteLine("Greška" + ex.Message);
                }
            }
        }
        private static void UnesiTelefon(Ucenik ucenik)
        {
            // Korisnik mora ispravno unijeti oib
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite telefon: ");

                try
                {
                    ucenik.Telefon = int.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }

                catch (FormatException ex) // specijalne greške
                {
                    Console.WriteLine("Greška:" + ex.Message);
                }
                catch (Exception ex)// ostale greške
                {
                    Console.WriteLine("Greška" + ex.Message);
                }
            }
        }

        private static void IspisUcenika(Ucenik ucenik)
        {
            Console.WriteLine("Ucenik: " + ucenik.Ime + " " + ucenik.Prezime + ", oib: " + ucenik.PartialOib
                + " na računu ima: " + ucenik.Racun + " hrk.");
        }

        private static void IspisUcenika2(Ucenik ucenik)
        {
            Console.WriteLine("Ucenik: " + ucenik.Ime + " " + ucenik.Prezime + ", oib: " + ucenik.PartialOib 
                + " nakon plačanja školarine na računu ima: " + ucenik.Stanje() + " hrk.");
        }
    }
}
