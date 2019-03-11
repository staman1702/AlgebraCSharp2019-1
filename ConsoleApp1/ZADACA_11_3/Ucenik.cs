namespace ZADACA_11_3
{
    internal class Ucenik
    {

        //string ime = "";
        //string prezime = "";
        private int oib;
     
        public int racun;
        public int telefon = 0;

        Ucenik()
        {
        }

        string ime = "";
        public string Ime
        {
            get { return ime; }
            set => ime = ToUpper.FirstCharToUpper(value);
        }

        string prezime = "";
        public string Prezime
        {

            get { return prezime; }
            set => prezime = ToUpper.FirstCharToUpper(value);
        }

        
        public int Oib
        {
            get { return oib; }
            set { oib = value; }
        }
        public int PartialOib
        {
            get => int.Parse(oib.ToString().Substring(0, 3));
        }

        
        public int Racun
        {
            get { return racun; }
            set { racun = value; }
        }

        public int Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public Ucenik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
        public Ucenik(string ime, string prezime, int oib)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.oib = oib;
        }

        public Ucenik(string ime, string prezime, int oib, int racun)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.oib = oib;
            this.racun = racun;
        }

        public int Stanje()
        {
            int stanje = 0;
            stanje = (int) racun - 900;
            return stanje;
        }

        public override string ToString()
        {
            return "Pozdrav, " + this.Ime + " " + this.Prezime + " " + this.Racun.ToString();
        }
    }
}