namespace ZADACA_11_3
{
    internal class Ucenik
    {
        public string ime = "";
        public string prezime = "";
        string oib = "";

        Ucenik()
        {

        }

        public string Ime
        { get => ime;
          set => ToUpper.FirstCharToUpper(value);
        }


        public string Prezime
        {
            get => prezime;
            set => ToUpper.FirstCharToUpper(value);
        }

        public string OIB
        {
            get { return oib; }
            set { oib = value; }

        }

        public int racun;
        public int Racun
        {
            get { return racun; }
            set { racun = value; }
        }

        public override string ToString()
        {
            return "Pozdrav, " + this.Ime + " " + this.Prezime + " " + this.Racun.ToString();
        }
    }
}