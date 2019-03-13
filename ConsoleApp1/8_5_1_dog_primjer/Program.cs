using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_1_dog_primjer
{
    class Program
    {
        static void Main(string[] args)
        {

            Osoba osoba = new Osoba();
            osoba.NaPromjenuImena += new
                Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena);
            osoba.Ime = "Pero";

            osoba.NaPromjenuImena -= new
                Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena);

            Console.ReadLine();
        }

        static void osoba_NaPromjenuImena(object sender, EventArgs e)
        {
            Console.WriteLine(
                "Osoba je promjenila podatke: {0}", ((Osoba)sender).Ime);
        }

        
    }
}
