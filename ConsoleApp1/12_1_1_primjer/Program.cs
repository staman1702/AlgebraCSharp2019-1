using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_1_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum1 = new DateTime(2015, 1, 1);
            DateTime datum2 = new DateTime(2016, 8, 1);
            DateTime datum3 = new DateTime(2016, 8, 1);

            if (datum1 < datum2)
            {
                Console.WriteLine(datum1.ToString() + " je manji od " + datum2.ToString());
            }
            else
            {
                Console.WriteLine(datum1.ToString() + " je veći od " + datum2.ToString());
            }
            Console.WriteLine("Trenutno je " + DateTime.Now);

            Console.WriteLine("Danas je " + DateTime.Today);

            Console.WriteLine("Danas je " + DateTime.Today.DayOfWeek);

            Console.WriteLine(datum1 + " + 7 dana je " +datum3.AddDays(7));

            //(Uvijet)?true:false

            Console.WriteLine((DateTime.IsLeapYear(2000))? "Ovo je prijestupna godina":"Ovo nije prijestupna godina");
            Console.ReadLine();
        }
    }
}
