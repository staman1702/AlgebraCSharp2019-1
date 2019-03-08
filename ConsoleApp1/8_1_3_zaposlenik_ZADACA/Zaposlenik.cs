namespace _8_1_3_zaposlenik_ZADACA
{
    internal class Zaposlenik
    {

        //svojstva
        string ime = "";
        public string Ime
        {
            get { return ime; }
            set { ime = value;  }
        }
        string prezime = "";
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value;  }
        }
        string oib = "";
        public string OIB
        {
            get { return oib; }
            set { oib = value;  }
        }

        public double bbod = 0;
        public double vbod = 0;
        public double porez = 0;
       


        //defaultni konstruktor

        #region DEFAULTNI KONSTRUKTOR 
        public Zaposlenik()
        {
            
        }
        #endregion


        //konstruktor sa argumentima (parametrima): ime, prezime
        public Zaposlenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        //konstruktor sa argumentima: ime, prezime, oib

            //sa naredbom :this(ime, prezime) smo dodali ono iz konstruktora iznad!!

        public  Zaposlenik( string ime, string prezime, string oib) :this(ime, prezime)
        {
          
            this.OIB = oib;
        }

       





        //metoda za neto placu
        public double NetoP()
        {
            double netop = 0;
            netop = (double) this.bbod * this.vbod;
            return netop;
        }

        
        
        public double Porez
        {
            get
            {
                double porez = 0;

                if (this.NetoP() < 3000)
                {
                    porez = 6 / 100;
                }
                else if (this.NetoP() < 6000)
                {
                    porez = 12 / 100;
                }
                else
                {
                    porez = 20 / 100;
                }
                return porez;
            }
        }

        //metoda za bruto placu
        public double BrutoP()
        {
            double brutop = 0;
            brutop = (double)this.NetoP() + (this.NetoP() * this.porez);
            return brutop;

        }


    }
}