using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_1_nasljedivanje
{
    public class Automobil
    {
        public string marka = "";
        public double ks = 0;
        public double oscijena = 0;
        public DateTime datumNastanka;

        public Automobil()
        {
            this.datumNastanka = DateTime.Now;
        }

        public Automobil(string v)
        {
            this.marka = v;
        }

        public double mpc()
        {
            double mpc = 0;

            if (ks < 50)
            {
                mpc = (double)oscijena + (oscijena * 0.05);


            }
            if (ks >= 50 && ks < 150)
            {
                mpc = (double)oscijena + (oscijena * 0.1);



            }
            else
            {
                mpc = (double)oscijena + (oscijena * 0.15);

            }

            return mpc;


        }
    }
}
