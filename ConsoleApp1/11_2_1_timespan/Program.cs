using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_1_timespan
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime datum1 = new DateTime(2015, 1, 1, 10, 0, 0);
            DateTime datum2 = new DateTime(2018, 8, 1, 12, 0, 0);

            TimeSpan interval = datum2 - datum1;

            Console.WriteLine("Interval između {0} i {1} je {2}", datum1, datum2, interval);
            
            Console.WriteLine(" dana " + interval.Days);
            Console.WriteLine(" sati " + interval.Hours);
            Console.WriteLine("sveukupno sati " + interval.TotalHours);
            Console.WriteLine("sveukupno minuta " + interval.TotalMinutes);


            Console.ReadLine();


        }
    }
}
