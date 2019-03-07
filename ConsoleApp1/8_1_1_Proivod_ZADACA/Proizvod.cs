using System;

namespace _8_1_1_Proivod_ZADACA
{
    internal class Proizvod
    {
        public string ime = "";
        public double cijena = 0;
        public double marza = 0;
        public double porez = 0;
        public DateTime datumNastanka;

        public Proizvod()
        {
            this.datumNastanka = DateTime.Now;
        }

        public Proizvod(string v)
        {
            this.ime = v;
        }

        public double mpc()
        {
            double mpc = 0;
            mpc = (double) cijena + ( cijena *  marza / 100 ) + ( cijena *  marza *  porez / 100 / 100);
            return mpc;

        }
    }
}