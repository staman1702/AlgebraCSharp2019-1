namespace _8_1_3_zaposlenik_ZADACA
{
    internal class Zaposlenik
    {

        //svojstva
        public string ime = "";
        public string prezime= "";
        public int oib = 0;
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
            this.ime = ime;
            this.prezime = prezime;
        }

        //konstruktor sa argumentima: ime, prezime, oib

        public  Zaposlenik( string ime, string prezime, int oib)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.oib = oib;
        }





        //metoda za neto placu
        public double NetoP()
        {
            double netop = 0;
            netop = (double) this.bbod * this.vbod;
            return netop;
        }

        
        
        public double Porez()
        {
            double porez = 0;
            
            if (this.NetoP() < 3000 )
            {
                porez = 6 / 100;
            }
            else if (this.NetoP() < 6000)
            {
                porez = 12 /100;
            }
            else
            {
                porez = 20 / 100;
            }
            return porez;

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